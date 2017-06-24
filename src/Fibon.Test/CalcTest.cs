using System;
using Xunit;
using System.Collections.Generic;

namespace Fibon.Test
{
    public class CalcTest
    {
        [Theory]
        [MemberData(nameof(Numbers))]
        public void DoWork(int number, int result)
        {
            
        }
        public static IEnumerable<object[]> Numbers()
        {
            yield return new object[] { 0, 0 };
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 1 };
            yield return new object[] { 3, 2 };
            yield return new object[] { 4, 3 };
            yield return new object[] { 5, 5 };
        }
    }
}
