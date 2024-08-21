namespace JsonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() {  Name = "Choclate" , CostPrice = 3 , SellPrice = 4};
            Product product2 = new Product() { Name = "Chicken", CostPrice = 4, SellPrice = 6 };
            ProductService service = new ProductService();
            service.Create(product1);
            service.Create(product2);
            service.GetAll();
        }
    }
}
