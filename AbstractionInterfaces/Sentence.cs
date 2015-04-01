using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public class Sentence
   {
      public static readonly char[] Delimiters = new char[] { 
         '.', ';', '!', '?', ':' };
      public static readonly char[] Whitespace = new char[] { 
         ' ', '\t', '\r', '\n' };
   
      public string Text { get; set; }
      public int Begin { get; set; }
      public int End { get; set; }
      public Dictionary<string, object> Annotations { get; set; }
      
      public Sentence()
      {
         Initialize();
      }
      
      public Sentence(string text, int begin, int end)
      {
         Initialize();
         
         Text = text;
         Begin = begin;
         End = end;
      }

      protected void Initialize()
      {
         Annotations = new Dictionary<string,object>();
      }
   }
}
