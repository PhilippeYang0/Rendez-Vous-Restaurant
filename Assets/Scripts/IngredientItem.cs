using UnityEngine.Events;

public class IngredientItem
{
    public IngredientSO IngredientSO;
    public uint Quantity;

    public IngredientItem(IngredientSO ingredientSO)
    {
        this.IngredientSO = ingredientSO;
    }
    public IngredientItem(IngredientSO ingredientSO, uint quantity)
    {
        this.IngredientSO = ingredientSO;
        this.Quantity = quantity;
    }

    public void Add(uint quantity)
    {
        Quantity += quantity;
    }

    public void Remove(uint quantity)
    {
        if (quantity >= Quantity)
        {
            Quantity = 0;
        }
        else
        {
            Quantity -= quantity;
        }
    }
}