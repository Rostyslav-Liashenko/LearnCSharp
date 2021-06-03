private int alpha;
        private int beta; 

        public MyClass(int i, int j)
        {
            alpha = i;
            beta = j;
        }

        public bool SameAs(MyClass ob)
        {
            return alpha == ob.alpha && beta == ob.beta;
        }

        public void Copy(MyClass ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, betta: {1}",alpha,beta);
        }
    }
}
