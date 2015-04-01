// -----------------------------------------------------------------------
// <copyright file="TermMatch.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace MC.MCRF.NLP.DocumentAbstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TermMatch
    {
        public int StartIndex { get; set; }
        public string Term { get; set; }

        public TermMatch() { }
        public TermMatch(int startIndex, string term)
        {
            StartIndex = startIndex;
            Term = term;
        }

        public class Comparer : IComparer<TermMatch>
        {
            public int Compare(TermMatch x, TermMatch y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }
                else if (x == null)
                {
                    return -1;
                }
                else if (y == null)
                {
                    return 1;
                }

                return x.StartIndex.CompareTo(y.StartIndex);
            }
        }
    }
}
