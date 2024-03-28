using Fluxor;

namespace BlazorServerFluxor;

public static class Reducers
{
    [ReducerMethod(typeof(AddToCartAction))]
    public static ShoppingCartState ReduceAddToCartAction(ShoppingCartState state)
    {
        return new ShoppingCartState(state.ItemCount + 1);
    }
}
