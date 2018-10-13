using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Result
    {
        /*
     * Complete the 'closestStraightCity' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY c
     *  2. INTEGER_ARRAY x
     *  3. INTEGER_ARRAY y
     *  4. STRING_ARRAY q
     */

        public static List<string> closestStraightCity(List<string> c, List<int> x, List<int> y, List<string> q)
        {
            List<string> resultCities = new List<string>();
            List<string> resultX = new List<string>();
            List<string> resultY = new List<string>();
            int i = -1;

            foreach (string sCity in c)
            {
                i++;

                resultX = findX(x[i], x, i, c);
                if (resultX.Count >= 1)
                {
                    resultX.Sort();
                    resultCities.Add(resultX[0]);
                    resultX.Clear();
                }
                else
                {
                    resultY = findY(y[i], y, i, c);
                    if (resultY.Count >= 1)
                    {
                        resultY.Sort();
                        resultCities.Add(resultY[0]);
                        resultY.Clear();
                    }
                    else
                    {
                        resultCities.Add("NONE");
                    }
                }
            }
            return resultCities;
        }

        public static List<string> findX(int valueToFind, List<int> x, int posIgnore, List<string> c)
        {
            List<string> sResult = new List<string>();
            int i = -1;
            foreach (int value in x)
            {
                i++;
                if (value == valueToFind && i != posIgnore)
                {
                    sResult.Add(c[i]);
                }
            }

            return sResult;
        }

        public static List<string> findY(int valueToFind, List<int> y, int posIgnore, List<string> c)
        {
            List<string> sResult = new List<string>();
            int i = -1;
            foreach (int value in y)
            {
                i++;
                if (value == valueToFind && i != posIgnore)
                {
                    sResult.Add(c[i]);
                }
            }

            return sResult;
        }


    }
}
