using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public class AorticAneurysmAnnotation : Annotation
   {
      #region Constants
      public const string SentenceRelatedTag = "Related";
      public const string SentenceExplicitTag = "Explicit";
      public const string SentenceNegatedTag = "Negated";
      public const string SentenceLocationTag = "Location";
      public const string SentenceMeasurementTag = "Measurement";
      public const string SentenceMeasurementDescrTag = "MeasureDesc";
      public const string SentenceNotAllRelatedTag = "NotAllRelated";
      public const string SentenceUnrelatedTermTag = "UnrelatedTerms";
      public const string SentenceSubjectTag = "Subject";
      
      public const string Patient = "Patient";
      public const string FamilyMember = "Family";
      public const string NoneOrHypothetical = "None";
      
      public const char UnrelatedTermDelimiter = ',';
      #endregion
   
      public override void LoadAnnotations(string file, List<Document> documents)
      {
         if (!File.Exists(file)) {
            return;
            }
            
         string[] annotations = File.ReadAllLines(file);
         Document currentDocument = null;
         foreach (string annotation in annotations) {
            string[] fields = annotation.Split(
               new string[] { Delimiter }, StringSplitOptions.None);
               
            if (annotation.StartsWith(DocumentLineIdentifier)) {
               currentDocument = documents.Find(delegate(Document doc) { return (doc.FilePath.Contains(fields[1]) || fields[1].Contains(doc.FilePath)); });
               if (currentDocument != null) {
                  currentDocument.Annotations.Add(DocumentCompletedTag, bool.Parse(fields[2]));
                  }
               }
            else if (annotation.StartsWith(SentenceLineIdentifier)) {
               if (currentDocument == null) {
                  continue;
                  }
                  
               int sentenceStart = int.Parse(fields[1]);
               int sentenceEnd = int.Parse(fields[2]);
               Sentence foundSent = currentDocument.Sentences.Find(delegate(Sentence sent) { return (sent.Begin == sentenceStart && sent.End == sentenceEnd); });
               if (foundSent != null) {
                  foundSent.Annotations.Add(SentenceRelatedTag, bool.Parse(fields[3]));
                  foundSent.Annotations.Add(SentenceExplicitTag, bool.Parse(fields[4]));
                  foundSent.Annotations.Add(SentenceNegatedTag, bool.Parse(fields[5]));
                  foundSent.Annotations.Add(SentenceLocationTag, bool.Parse(fields[6]));
                  foundSent.Annotations.Add(SentenceMeasurementTag, bool.Parse(fields[7]));
                  foundSent.Annotations.Add(SentenceMeasurementDescrTag, bool.Parse(fields[8]));
                  foundSent.Annotations.Add(SentenceNotAllRelatedTag, bool.Parse(fields[9]));
                  foundSent.Annotations.Add(SentenceUnrelatedTermTag, fields[10]);
                  foundSent.Annotations.Add(SentenceSubjectTag, fields[11]);
                  }
               }
            else if (annotation.StartsWith(CommentLineIdentifier)) {
               }
            else if (annotation.Trim() != string.Empty) {
               throw new Exception("Invalid line found in the annotation file");
               }
            }
      }
      
      public override void SaveAnnotations(string file, List<Document> documents)
      {
         if (File.Exists(file)) {
            File.Delete(file);
            }
            
         StreamWriter writer = null;
         try {
            writer = new StreamWriter(file);
            writer.AutoFlush = true;
            
            foreach (Document document in documents) {
               if (document.Annotations.Count == 0) {
                  continue;
                  }
                  
               writer.WriteLine("{0}{1}{2}{1}{3}", 
                  DocumentLineIdentifier, 
                  Delimiter, 
                  document.FilePath,
                  document.Annotations[DocumentCompletedTag]);
               
               foreach (Sentence sentence in document.Sentences) {
                  // Don't bother writing out sentences with no annotations
                  if (sentence.Annotations.Count == 0) {
                     continue;
                     }
                     
                  writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}",
                     SentenceLineIdentifier, 
                     Delimiter,
                     sentence.Begin,
                     sentence.End,
                     sentence.Annotations[SentenceRelatedTag],
                     sentence.Annotations[SentenceExplicitTag],
                     sentence.Annotations[SentenceNegatedTag],
                     sentence.Annotations[SentenceLocationTag],
                     sentence.Annotations[SentenceMeasurementTag],
                     sentence.Annotations[SentenceMeasurementDescrTag],
                     sentence.Annotations[SentenceNotAllRelatedTag],
                     sentence.Annotations[SentenceUnrelatedTermTag],
                     sentence.Annotations[SentenceSubjectTag]);
                  }
               }
            }
         finally {
            if (writer != null) {
               writer.Close();
               }
            }
      }
   }
}
