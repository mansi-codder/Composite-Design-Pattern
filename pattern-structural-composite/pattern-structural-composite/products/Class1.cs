using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_structural_composite.products
{
    public class DeliveryService
{

    private Box box;

    public DeliveryService()
    {
    }

    public void setupOrder(Box...boxes)
    {
        this.box = new CompositeBox(boxes);
    }

    public double calculateOrderPrice()
    {
        return box.calculatePrice();
    }

}

}
