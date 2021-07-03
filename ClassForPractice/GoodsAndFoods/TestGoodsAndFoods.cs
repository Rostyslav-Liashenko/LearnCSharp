namespace TestDifferentFeatures
{
    class TestGoodsAndFoods
    {
        static int Main()
        {
            Product[] products = new Product[2];
            products[0] = new Product("mouse", 20.45, 2021, 5, 12);
            products[1] = new Food("sausage", 15.65, 2020, 5, 12, 2021, 4, 1);
            foreach (var oneProduct in products)
                oneProduct.PrintInfo();
            return 0;
        }
    }
}
