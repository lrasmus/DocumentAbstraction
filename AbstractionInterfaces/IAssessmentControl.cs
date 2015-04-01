using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public interface IAssessmentControl
   {
      TermDictionary Terms { get; set; }
      List<TermMatch> HighlightedSentenceTerms { get; set; }
      List<TermMatch> HighlightedDocumentTerms { get; set; }
      string StudyName { get; }

      event EventHandler<TextEventArgs> HighlightText;

      void LoadDocumentAnnotations(Document document);
      void SaveDocumentAnnotations(Document document);
      void LoadSentenceAnnotations(Sentence sentence);
      void SaveSentenceAnnotations(Sentence sentence);
   }
}
