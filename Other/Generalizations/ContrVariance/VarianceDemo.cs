namespace LearnGeneralization
{
    public class VarianceDemo
    {
        public static void Main()
        { 
            IMyContraVarGenIF<Alpha> alphaRef = new MyClass<Alpha>();
            IMyContraVarGenIF<Beta> betaRef = new MyClass<Beta>();
            IMyContraVarGenIF<Beta> betaRef2 = new MyClass<Alpha>();
            betaRef2.Show(new Beta());
            betaRef = alphaRef;
            betaRef.Show(new Beta());
        }
    }
}    