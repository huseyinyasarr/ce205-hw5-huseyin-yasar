using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @file ce205_hw4_knuth_horspool_boyer.cs
 * @author Alper SAHIN, HUSEYIN YASAR
 * @date 29 December 2022
 *
 * @brief <b> HW-5 Functions </b>
 *
 * HW-5 Sample Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce205_hw5_knuth_horspool_boyer
{
    public class Class1
    {
        public static class Knuth_Morris_Pratt_Algorithm
        {
            /**
            *   @name   ComputeLps
            *
            *   @brief  This method computes the longest prefix suffix (lps) values for the given pattern.
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] return lps 
            **/
            public static int[] ComputeLps(string pattern)
            {
                int[] lps = new int[pattern.Length];
                int i = 1;
                int j = 0;
                while (i < pattern.Length)
                {
                    if (pattern[i] == pattern[j])
                    {
                        lps[i] = j + 1;
                        i++;
                        j++;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            lps[i] = 0;
                            i++;
                        }
                        else
                        {
                            j = lps[j - 1];
                        }
                    }
                }
                return lps;
            }

            /**
            *   @name   KMPSearch
            *
            *   @brief  Knuth Morris Pratt Algorithm
            *   
            *   This method performs a Knuth Morris Pratt (KMP) search on the given text for the given pattern.
            *   
            *   @param  [in] text [\b string]  is the text input to be entered
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] if patttern length equal j, return i-j. Else return -1.
            **/
            public static int KMPSearch(string text, string pattern)
            {
                int[] lps = ComputeLps(pattern);
                int i = 0;
                int j = 0;
                while (i < text.Length)
                {
                    if (text[i] == pattern[j])
                    {
                        i++;
                        j++;
                    }
                    if (j == pattern.Length)
                    {
                        return i - j;
                    }
                    else if (i < text.Length && text[i] != pattern[j])
                    {
                        if (j == 0)
                        {
                            i++;
                        }
                        else
                        {
                            j = lps[j - 1];
                        }
                    }
                }
                return -1;
            }
        }
        public static class Horspool_Algorithm
        {
            /**
            *   @name   Search
            *
            *   @brief Horspool Algorithm
            *
            *   Calculates the Horspool algorithm in the given inputs and return as output
            *
            *   @param  [in] haystack [\b string]  is the pattern input to be entered
            *   
            *   @param  [in] needle [\b string]  is the text input to be entered
            *   
            *   @param  [in] startIndex [\b int]  is the starting index
            *
            *   @retval [\b int] if finds return the index if not return -1 
            **/
            public static int Search(string haystack, string needle, int startIndex)
            {

                int haystackLength = haystack.Length;
                int needleLength = needle.Length;

                for (int i = startIndex + needleLength - 1; i < haystackLength; i++)
                {
                    int j;
                    for (j = 0; j < needleLength; j++)
                    {
                        if (haystack[i - j] != needle[needleLength - 1 - j])
                        {
                            break;
                        }
                    }
                    if (j == needleLength)
                    {
                        return i - needleLength + 1;
                    }
                }
                return -1;
            }


        }

        public static class BoyerMooreAlgorithm
        {
            /**
            *   @name   boyerMooreSearch
            *
            *   @brief Boyer Moore Algorithm
            *
            *   Calculates the Boyer Moore Algorithm in the given inputs and return as output
            *
            *   @param  [in] text [\b string]  is the text input to be entered
            *   
            *   @param  [in] pattern [\b string]  is the pattern input to be entered
            *
            *   @retval [\b int] if finds return i if not return -1 
            **/
            public static int boyerMooreSearch(string text, string pattern)
            {
                // when searching key word, moves through a string of text
                for (int i = 0; i < text.Length - pattern.Length; i++)
                {
                    int j;

                    // search key word
                    for (j = pattern.Length - 1; j >= 0; j--)
                    {
                        if (pattern[j] != text[i + j])
                        {
                            break;
                        }
                    }

                    // if found keyword return
                    if (j < 0)
                    {
                        return i;
                    }
                }

                // if not found, return -1
                return -1;
            }
        }
    }
}