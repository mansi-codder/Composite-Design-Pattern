namespace pattern_structural_composite.products
{
    public class Book : Product
    {

        public Book(string title, double price)
            :(title, price)
        {
        }


        public override double calculatePrice()
        {
            return getPrice();
        }

    }

}
