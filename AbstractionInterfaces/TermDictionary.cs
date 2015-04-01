using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public class TermDictionary
   {
      public Dictionary<string, List<string[]>> Terms { get; set; }
   
      #region Constructor/initialization
      public TermDictionary()
      {
         Initialize();
      }
      
      public TermDictionary(string file, string delimiter)
      {
         Initialize();
         LoadFile(file, delimiter);
      }
      
      protected void Initialize()
      {
         Terms = new Dictionary<string, List<string[]>>();
      }
      #endregion
      
      #region Term management
      /// <summary>
      /// Adds a new term to the dictionary.  If the term already exists, nothing
      /// is done.
      /// </summary>
      /// <param name="term"></param>
      public void AddSimpleTerm(string term)
      {
         if (!Terms.ContainsKey(term)) {
            Terms.Add(term, new List<string[]>());
            Terms[term].Add(new string[] { term });
            }
      }

      /// <summary>
      /// Remove a term from the dictionary.
      /// </summary>
      /// <param name="term">The term to be removed</param>
      public void RemoveTerm(string term)
      {
          if (Terms.ContainsKey(term))
          {
              Terms.Remove(term);
          }
      }
      #endregion
      
      #region File management
      public void LoadFile(string file, string delimiter)
      {
         if (!File.Exists(file)) {
            return;
            }
      
         string[] lines = File.ReadAllLines(file);
         foreach (string line in lines) {
            string[] fields = line.Split(new string[] {delimiter}, StringSplitOptions.None);
            if (!Terms.ContainsKey(fields[0])) {
               Terms.Add(fields[0], new List<string[]>());
               }
               
            Terms[fields[0]].Add(fields);
            }
      }
      
      public void SaveFile(string file, string delimiter)
      {
         if (File.Exists(file)) {
            File.Delete(file);
            }
         
         StreamWriter writer = null;
         try {   
            writer = new StreamWriter(file);
            writer.AutoFlush = true;
            foreach (List<string[]> termList in Terms.Values) {
               foreach (string[] terms in termList) {
                  if (terms.Length == 0) {
                     continue;
                     }
                     
                  for (int index = 0; index < terms.Length-1; index++) {
                     writer.Write("{0}{1}", terms[index], delimiter);
                     }
                  writer.WriteLine(terms[terms.Length-1]);
                  }
               }
            }
         finally {
            if (writer != null) {
               writer.Close();
               }
            }
      }
      #endregion
   }
}
