namespace pattern_structural_composite.products
{
    public class VideoGame : Product
    {

        public VideoGame(string title, double price)
        : base(title, price)
        {
        }


        public override double calculatePrice()
        {
            return getPrice();
        }

    }

}
