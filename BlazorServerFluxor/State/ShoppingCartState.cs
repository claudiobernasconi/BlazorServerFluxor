using Fluxor;

namespace BlazorServerFluxor;

[FeatureState]
public class ShoppingCartState
{
    public int ItemCount { get; }
    private ShoppingCartState()
    {
    }

    public ShoppingCartState(int itemCount)
    {
        ItemCount = itemCount;
    }
}
