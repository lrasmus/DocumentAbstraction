using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MC.MCRF.NLP.DocumentAbstraction;
using System.IO;

namespace VTEClinical
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class VTEAnnotation : Annotation
    {
        #region Constants
        public const string DocumentAssessmentTag = "DocumentAssessment";
        public const string DocumentReviewNotesTag = "DocumentReviewNotes";
        #endregion

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
                        currentDocument.Annotations.Add(DocumentAssessmentTag, fields[4]);
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

                    writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{5}",
                       DocumentLineIdentifier,
                       Delimiter,
                       document.FilePath,
                       document.Annotations[DocumentCompletedTag],
                       RemoveReservedCharactersInText(document.Annotations[DocumentReviewNotesTag].ToString()),
                       document.Annotations[DocumentAssessmentTag]
                       );
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
