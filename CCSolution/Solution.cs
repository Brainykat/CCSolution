using System;
using System.Linq;
using System.Collections.Generic;

namespace CCSolution
{
    public class Solution
    {
        public int  modulus(int num, int n) {
            if (num < 0) {
                do {
                    num += n;
                } while (num < 0);
            }
            return num % n;
        }
        public int solution(int[] A, int M)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (M <= 0)
                return 0;
            if (A.Length == 0) return 0;
            List<int> l = new List<int>();
            var ret = (from a in A
                       from b in A
                       where (Math.Abs(a) - Math.Abs(b)) % M == 0
                       select new
                       {
                           a
                       });
            var sw = ret.Distinct();
            for (int j = 0; j < sw.Count(); j++)
            {
                var f = A.Where(x => (Math.Abs(A[j]) - Math.Abs(x)) % M == 0).Count();
                l.Add(f);
            }
            return l.Max() ;
        }
            public int solutiona(int[] A, int M)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (M <= 0)
                return 0;
            if (A.Length == 0) return 0;
            List<int> l = new List<int>();
            //for (int j = 0; j < A.Length; j++)
            //{
            //    var f = A.Where(x => (Math.Abs(A[j]) - Math.Abs(x)) % M == 0).Count();
            //    l.Add(f);
            //}
            //return l.Max();

            var ret = (from a in A
                       from b in A
                       where (Math.Abs(a) - Math.Abs(b)) % M == 0
                       select new
                       {
                           a
                       });
            var sw = ret.Distinct();
            var min = sw.Min();
            //List<int> l = new List<int>();
            for (int j = 0; j < sw.Count(); j++)
            {
                var f = A.Where(x => (Math.Abs(A[j]) - Math.Abs(x)) % M == 0).Count();
                l.Add(f);
            }
            return l.Max() + 1;






            //*********************

            //for (int i = 0; i <= A.Length; i++)
            //{
            //    all.Add(A[i]);
            //    for (int j = 0; j < A.Length; j++)
            //    {
            //        if (Math.Abs(A[i] - A[j]) % M == 0)
            //        {

            //            all.Add(A[j]);
            //        }
            //    }
            //}
            //var j = A.Distinct().Where(f => Math.Abs(f) % M == 0);
            //return j.Count();
        }
    }
}
