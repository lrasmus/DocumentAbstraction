using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MC.MCRF.NLP.DocumentAbstraction;
using System.IO;

namespace MC.MCRF.NLP.PROSPECT
{
   public class MedAdherenceAnnotation : Annotation
   {
      #region Constants
      public const string DocumentReviewTag = "DocumentReview";
      public const string DocumentReviewNotesTag = "DocumentReviewNotes";
      
      public const string SentenceAdherenceTag = "Adherence";
      public const string SentenceNonAdherenceTag = "NonAdherence";
      public const string SentenceBarriersTag = "Barriers";
      public const string SentenceAssistanceTag = "Assistance";
      public const string SentenceAmbiguousTag = "Ambiguous";
      public const string SentenceOtherTag = "Other";
      public const string SentenceOtherNotesTag = "OtherNotes";
      public const string SentenceNotesTag = "Notes";
      public const string SentenceReviewTag = "SentenceReview";
      public const string SentenceReviewNotesTag = "SentenceReviewNotes";
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
               currentDocument = documents.Find(delegate(Document doc) { return Path.GetFileName(doc.FilePath) == Path.GetFileName(fields[1]); });
               if (currentDocument != null) {
                  currentDocument.Annotations.Add(DocumentCompletedTag, bool.Parse(fields[2]));
                  currentDocument.Annotations.Add(DocumentReviewTag, bool.Parse(fields[3]));
                  currentDocument.Annotations.Add(DocumentReviewNotesTag, fields[4]);
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
                  foundSent.Annotations.Add(SentenceAdherenceTag, bool.Parse(fields[3]));
                  foundSent.Annotations.Add(SentenceNonAdherenceTag, bool.Parse(fields[4]));
                  foundSent.Annotations.Add(SentenceBarriersTag, bool.Parse(fields[5]));
                  foundSent.Annotations.Add(SentenceAssistanceTag, bool.Parse(fields[6]));
                  foundSent.Annotations.Add(SentenceAmbiguousTag, bool.Parse(fields[7]));
                  foundSent.Annotations.Add(SentenceOtherTag, bool.Parse(fields[8]));
                  foundSent.Annotations.Add(SentenceOtherNotesTag, fields[9]);
                  foundSent.Annotations.Add(SentenceNotesTag, fields[10]);
                  foundSent.Annotations.Add(SentenceReviewTag, bool.Parse(fields[11]));
                  foundSent.Annotations.Add(SentenceReviewNotesTag, fields[12]);
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
                  
               writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{5}", 
                  DocumentLineIdentifier, 
                  Delimiter, 
                  document.FilePath,
                  document.Annotations[DocumentCompletedTag],
                  document.Annotations[DocumentReviewTag],
                  RemoveReservedCharactersInText(document.Annotations[DocumentReviewNotesTag].ToString())
                  );
               
               foreach (Sentence sentence in document.Sentences) {
                  // Don't bother writing out sentences with no annotations
                  if (sentence.Annotations.Count == 0) {
                     continue;
                     }
                     
                  writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}{13}",
                     SentenceLineIdentifier, 
                     Delimiter,
                     sentence.Begin,
                     sentence.End,
                     sentence.Annotations[SentenceAdherenceTag],
                     sentence.Annotations[SentenceNonAdherenceTag],
                     sentence.Annotations[SentenceBarriersTag],
                     sentence.Annotations[SentenceAssistanceTag],
                     sentence.Annotations[SentenceAmbiguousTag],
                     sentence.Annotations[SentenceOtherTag],
                     RemoveReservedCharactersInText(sentence.Annotations[SentenceOtherNotesTag].ToString()),
                     RemoveReservedCharactersInText(sentence.Annotations[SentenceNotesTag].ToString()),
                     sentence.Annotations[SentenceReviewTag],
                     RemoveReservedCharactersInText(sentence.Annotations[SentenceReviewNotesTag].ToString())
                     );
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
