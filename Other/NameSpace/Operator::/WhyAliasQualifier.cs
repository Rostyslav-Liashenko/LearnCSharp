using Counter;
using AnotherCounter;

using Ctr = Counter;

class WhyAliasQualifier
{
    static void Main()
    {
        Ctr::CountDown cd = new Ctr::CountDown(10);
    }
}
