using System.Collections.Generic;

namespace pattern_structural_composite.products
{
    public class CompositeBox : Box
    {

    private  List<Box> children = new ArrayList<>();

    public CompositeBox(Box ...boxes)
    {
        children.addAll(Arrays.asList(boxes));
    }

    
    public override double calculatePrice()
    {
        return children.stream().mapToDouble(Box::calculatePrice).sum();
    }

}

}
