using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class StringMethod
    {

        /// <summary>
        /// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        /// Leave punctuation marks untouched. ie Pig become igPye
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));


            //                  1
            //return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");

            //                 2
            //StringBuilder sB = new StringBuilder();
            //var words = str.Split(' ').ToList();
            //words.ForEach(a => sB.Append( a + a.Remove(0, 1) + "ay"));


            //StringBuilder sB1 = new StringBuilder();
            //bool isLast = false;

            //foreach (var word in words)
            //{
            //    if (words.Last() == word)
            //        isLast = true;

            //    string lastEle = isLast == true ? "" : " ";
            //    var withoutFirstLetter = word.Substring(1, word.Length - 1);
            //    var firstLetter = word.First();
            //    string final = withoutFirstLetter + firstLetter + "ay" + lastEle;
            //    sB.Append(final);
            //}

            //return sB.ToString();
        }

        /// <summary>
        /// Repeat string s given times (n)
        /// </summary>
        /// <param name="n">How many times string will be concat</param>
        /// <param name="s">string to concat</param>
        /// <returns></returns>
        public string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));

            //StringBuilder resultRepeated = new StringBuilder();
            //for (int i = 0; i < n; i++)
            //{
            //    resultRepeated.Append(s);
            //}
            //return resultRepeated.ToString();
        }

        /// <summary>
        /// Find shortest string. Words in string must be seperetaed using white space
        /// </summary>
        /// <param name="s">string in which shortsets string will be found</param>
        /// <returns></returns>
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(a => a.Length);
        }

        /// <summary>
        /// Cuts the string into chunks of size sz (ignores the last chunk is its size is less than sz)
        /// If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2, reverse that chunk; otherwise rotate it to the left by one position. Put together these modified chunks and return the result as a string.
        /// </summary>
        /// <param name="strng">string to cut</param>
        /// <param name="sz">amount to which string will be chunked</param>
        /// <returns>chunked string correct with description</returns>
        public string RevRot(string strng, int sz)
        {
            if (strng.Length <= sz)
                return string.Empty;

            List<string> listOfChunks = new List<string>();
            List<string> chunksToReturn = new List<string>();
            StringBuilder sB = new StringBuilder();
            int repeatSz = 0;
            int letterCounter = 0;

            while (true)
            {
                if (letterCounter == sz)
                {
                    listOfChunks.Add(sB.ToString());
                    sB = new StringBuilder();
                    letterCounter = 0;
                }

                sB.Append(strng[repeatSz]);
                repeatSz++;
                letterCounter++;

                if (repeatSz >= strng.Length)
                {
                    if (letterCounter == sz)
                        listOfChunks.Add(sB.ToString());
                    break;
                }
            }

            listOfChunks.ForEach(a =>
            {
                //If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2, reverse that chunk; 
                if (CubeOfAll(a) % 2 == 0)
                    chunksToReturn.Add(new string(a.Reverse().ToArray()));
                else
                    chunksToReturn.Add(ShiftString(a));
            });
            

            return String.Join("",chunksToReturn.ToArray());
        }

        /// <summary>
        /// First non-repeating character
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string FirstNonRepeatingLetter(string s)
        {
            if (s.Length == 1) return s;
            string toReturn = "";
            var sList = s.ToList();
            //var zz = sList.Where(a => sList.Sum((b) => b) == 1).First();
            foreach (var item in sList)
            {
                    if (sList.Where(b => string.Equals(item.ToString(), b.ToString(), StringComparison.CurrentCultureIgnoreCase)).Count() == 1)
                    {
                        toReturn = item.ToString();
                        break;
                    }   
            }
            return toReturn;

            //foreach (var item in s.ToList())
            //{
            //    if (s.ToList().Any(a => a != item))
            //        return item.ToString();
            //}
            //return "";
            //s.ToList().Any(a =>
            //{
            //    if (s.ToList().Any(b => a != b))
            //        return a;
            //});
            //char letterToReturn = ' ';
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (letterToReturn != s[i] && i != s.Length - 1)
            //    {
            //        letterToReturn = s[i];
            //        continue;
            //    }

            //    if()
            //    letterToReturn = s[i];
            //}
        }



        private  int CubeOfAll(string stringWithIntegers)
        {
            int number = 0;
            stringWithIntegers.ToList().ForEach(a =>
            {
                int numberOfChar = Convert.ToInt32(a.ToString());
                number += numberOfChar * numberOfChar * numberOfChar;
            });
            return number;
        }
        private  string ShiftString(string t)
        {
            //ABC == BC + remaing A
            return t.Substring(1, t.Length - 1) + t.Substring(0, 1);
        }
    }
}
