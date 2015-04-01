using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public class Document
   {
      #region Properties
      public string FilePath { get; set; }
   
      private string m_text = "";
      public string Text 
      { 
         get
         {
            return m_text;
         }
         
         set
         {
            if (m_text != value) {
               m_text = value;
               BuildSentences();
               }
         }
      }
      
      public List<Sentence> Sentences { get; set; }
      public Dictionary<string, object> Annotations { get; set; }
      #endregion
   
      #region Constructors
      public Document()
      {
         Initialize();
      }
      
      public Document(string file)
      {
         Initialize();
         LoadFromFile(file);
      }
      #endregion
      
      public void LoadFromFile(string file)
      {
         Text = File.ReadAllText(file);
         FilePath = file;
      }

      protected void Initialize()
      {
         Sentences = new List<Sentence>();
         Annotations = new Dictionary<string,object>();
      }
      
      protected void BuildSentences()
      {
         int currentIndex = 0;
         for (int index = 0; index < Text.Length; index++) {
            // If we're at the end, accept the sentence.
            if (index == (Text.Length - 1) && currentIndex != index) {
               Sentence sentence = new Sentence(
                  Text.Substring(currentIndex, index-currentIndex).Trim(),
                  currentIndex, index);
               Sentences.Add(sentence);
               }
         
            if (!Sentence.Delimiters.Contains(Text[index])) {
               continue;
               }
               
            // If we're at the end of the sentence (scanning ahead one character
            // means we exceed the length) we can stop.
            if (Text.Length <= (index + 1)) {
               continue;
               }
               
            // If we find a delimiter, scan ahead for whitespace
            if (Sentence.Whitespace.Contains(Text[index + 1])) {
               Sentence sentence = new Sentence(
                  Text.Substring(currentIndex, index-currentIndex).Trim(),
                  currentIndex, index);
               Sentences.Add(sentence);
               currentIndex = index + 1;
               }
            }
      }
   }
}
