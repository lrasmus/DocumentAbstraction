using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.MCRF.NLP.DeIdentification
{
   /// <summary>
   /// The following logic is derived from the publication:
   ///   Neamatullah, Ishna et al. “Automated de-identification of free-text
   ///   medical records.” BMC Medical Informatics and Decision Making
   ///   8.1 (2008): 32.
   ///   
   ///   http://dx.doi.org/10.1186/1472-6947-8-32
   /// </summary>
   public class DocumentProcessor
   {
      
      public string DateNumericPattern = @"\b(\d\d?)[\-\/](\d\d?)[\-\/](\d\d|\d{4})\b";
      public string DateMonthPattern = @"\b((\d{1,2})(|st|nd|rd|th|)?( of)?[ \-]\b(January|Jan|February|Feb|March|Mar|April|Apr|May|June|Jun|July|Jul|August|Aug|September|Sep|Sept|October|Oct|November|Nov|December|Dec)\b";
      public string POBoxNumberPattern = @"\b(P\.?O\.?\s*Box\s*\#?\s*[0-9]+)\b";
   }
}
