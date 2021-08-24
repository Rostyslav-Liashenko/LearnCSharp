using System;

namespace LearnFeatures
{
    static class SpanDemo
    {
        static  void Main()
        {
            int[] temperatures = new int[]
            {
                10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
                18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
                12, 14, 15, 15, 16, 15, 13, 12, 12, 11
            };
            Span<int> temperaturesSpan = temperatures;
            Span<int> firstDecade = temperaturesSpan.Slice(0, 10);
            Span<int> lastDecade = temperaturesSpan.Slice(20, 10);
            
        }
    }
}
