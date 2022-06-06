using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SparkfishRestAPI.Services
{
    public class ListifyComputation
    {

        public static IEnumerable<int> retrieveRange(int x, int y)
        {
            return Enumerable.Range(x, y);
        }

        public static List<TSource> ToList<TSource>(IEnumerable<TSource> p1)
        {
            return new List<TSource>(p1);
        }

        public static int retrieveValueInList(List<int> p1List, int indexVal)
        {
            int value = p1List.ElementAt(indexVal);
            return value;
        }
    }
}