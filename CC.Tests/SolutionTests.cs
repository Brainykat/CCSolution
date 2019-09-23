using CCSolution;
using System;
using Xunit;

namespace CC.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { -3, -2, 1, 0, 8,7,1 }, 3, 4)]
        [InlineData(new int[] { 7,1,11,8,4,10}, 8, 1)]
        public void solution_RotatesArray_N_Times(int[] a, int k, int result)
        {
            Solution sln = new Solution();
            var res = sln.solution(a, k);
            Assert.Equal(result, res);
        }
    }
}
