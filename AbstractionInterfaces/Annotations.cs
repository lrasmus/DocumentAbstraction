using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public abstract class Annotation
   {
      protected const string DocumentLineIdentifier = "DOC";
      protected const string SentenceLineIdentifier = "SENT";
      protected const string CommentLineIdentifier = "#";
      protected const string Delimiter = "|";
      protected readonly char[] ReservedCharacters = new char[] { '\r', '\n', '\t' };
      
      public const string DocumentCompletedTag = "Completed";
   
      public abstract void LoadAnnotations(string file, List<Document> documents);
      public abstract void SaveAnnotations(string file, List<Document> documents);
      
      public string RemoveReservedCharactersInText(string text)
      {
         string newText = text;
         foreach (char replaceChar in ReservedCharacters) {
            newText = newText.Replace(replaceChar, ' ');
            }
            
         return newText;
      }
   }
}
