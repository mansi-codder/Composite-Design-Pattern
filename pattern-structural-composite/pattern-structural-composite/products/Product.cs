namespace pattern_structural_composite.products
{
    public abstract class Product : Box
    {

        protected string title;
        protected double price;

        public abstract double calculatePrice();
    }

}
