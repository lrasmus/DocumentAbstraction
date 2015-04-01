// -----------------------------------------------------------------------
// <copyright file="ColonPolypAnnotation.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ColonPolypAbstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MC.MCRF.NLP.DocumentAbstraction;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ColonPolypAnnotation : Annotation
    {
        #region Constants
        public const string DocumentPolypFindingsTag = "DocumentPolypFindings";
        public const string DocumentReviewNotesTag = "DocumentReviewNotes";
        #endregion

        public class Finding
        {
            public string Type { get; set; }
            public string Location { get; set; }
        }

        public override void LoadAnnotations(string file, List<Document> documents)
        {
            if (!File.Exists(file))
            {
                return;
            }

            string[] annotations = File.ReadAllLines(file);
            Document currentDocument = null;
            foreach (string annotation in annotations)
            {
                string[] fields = annotation.Split(
                   new string[] { Delimiter }, StringSplitOptions.None);

                if (annotation.StartsWith(DocumentLineIdentifier))
                {
                    currentDocument = documents.Find(delegate(Document doc) { return Path.GetFileName(doc.FilePath) == Path.GetFileName(fields[1]); });
                    if (currentDocument != null)
                    {
                        currentDocument.Annotations.Add(DocumentCompletedTag, bool.Parse(fields[2]));
                        currentDocument.Annotations.Add(DocumentReviewNotesTag, fields[3]);
                        List<Finding> findings = new List<Finding>();
                        currentDocument.Annotations.Add(DocumentPolypFindingsTag, findings);
                        if (fields.Length > 4)
                        {
                            for (int index = 4; index < fields.Length; index += 4)
                            {
                                findings.Add(new Finding()
                                {
                                    Location = fields[index],
                                    Type = (index == fields.Length - 1) ? "" : fields[index + 1]
                                });
                            }
                        }
                    }
                }
                else if (annotation.StartsWith(SentenceLineIdentifier))
                {
                }
                else if (annotation.StartsWith(CommentLineIdentifier))
                {
                }
                else if (annotation.Trim() != string.Empty)
                {
                    throw new Exception("Invalid line found in the annotation file");
                }
            }
        }

        public override void SaveAnnotations(string file, List<Document> documents)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(file);
                writer.AutoFlush = true;

                foreach (Document document in documents)
                {
                    if (document.Annotations.Count == 0)
                    {
                        continue;
                    }

                    writer.Write("{0}{1}{2}{1}{3}{1}{4}",
                       DocumentLineIdentifier,
                       Delimiter,
                       document.FilePath,
                       document.Annotations[DocumentCompletedTag],
                       RemoveReservedCharactersInText(document.Annotations[DocumentReviewNotesTag].ToString())
                       );
                    List<Finding> findings = document.Annotations[DocumentPolypFindingsTag] as List<Finding>;
                    if (findings != null && findings.Count > 0)
                    {
                        foreach (var finding in findings)
                        {
                            writer.Write("{0}{1}{0}{2}", Delimiter, finding.Location, finding.Type);
                        }
                    }
                    writer.WriteLine();
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }
}
