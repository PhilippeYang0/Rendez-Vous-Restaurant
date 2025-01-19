using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using UnityEngine.Events;

public class IngredientInventory
{
    private readonly List<IngredientItem> _ingredientItems = new List<IngredientItem>();
    public int Count => _ingredientItems.Count;
    public UnityEvent IngredientInventoryUpdateEvent = new UnityEvent();

    public IngredientInventory(List<IngredientItem> ingredientItems)
    {
        _ingredientItems = ingredientItems;
    }
    public IngredientItem this[int index]
    {
        get
        {
            return _ingredientItems[index];
        }
    }
    public uint Contains(IngredientItem ingredientItem)
    {
        foreach (IngredientItem i in _ingredientItems)
        {
            if (i.IngredientSO == ingredientItem.IngredientSO)
            {
                return i.Quantity;
            }
        }
        return 0;
    }
    public uint Contains(IngredientSO ingredientSO)
    {
        foreach (IngredientItem i in _ingredientItems)
        {
            if (i.IngredientSO == ingredientSO)
            {
                return i.Quantity;
            }
        }
        return 0;
    }
    public void Add(IngredientItem ingredientItem)
    {
        foreach (var i in _ingredientItems)
        {
            if(i.IngredientSO == ingredientItem.IngredientSO)
            {
                i.Add(ingredientItem.Quantity);
                return;
            }
        }
        _ingredientItems.Add(ingredientItem);
        IngredientInventoryUpdateEvent.Invoke();
    }
    public void Add(IngredientSO ingredientSO,uint quantity = 1)
    {
        foreach (var i in _ingredientItems)
        {
            if(i.IngredientSO == ingredientSO)
            {
                i.Add(quantity);
                return;
            }
        }
        _ingredientItems.Add(new IngredientItem(ingredientSO,quantity));
        IngredientInventoryUpdateEvent.Invoke();
    }

    public void Remove(IngredientItem ingredientItem)
    {
        foreach (var i in _ingredientItems)
        {
            if(i.IngredientSO == ingredientItem.IngredientSO)
            {
                i.Remove(ingredientItem.Quantity);
                if(i.Quantity == 0)
                {
                    _ingredientItems.Remove(i);
                }
                IngredientInventoryUpdateEvent.Invoke();
                return;
            }
        }
    }
    public void Remove(IngredientSO ingredientSO,uint quantity = 1)
    {
        foreach (var i in _ingredientItems)
        {
            if(i.IngredientSO == ingredientSO)
            {
                i.Remove(quantity);
                if(i.Quantity == 0)
                {
                    _ingredientItems.Remove(i);
                }
                IngredientInventoryUpdateEvent.Invoke();
                return;
            }
        }
    }
    public void Clear()
    {
        _ingredientItems.Clear();
        IngredientInventoryUpdateEvent.Invoke();
    }

    public void Reverse()
    {
        _ingredientItems.Reverse();
        IngredientInventoryUpdateEvent.Invoke();
    }
    public void Sort(Comparison<IngredientItem> comparison)
    {
        _ingredientItems.Sort(comparison);
        IngredientInventoryUpdateEvent.Invoke();
    }

    public static int CompareByName(IngredientItem x,IngredientItem y)
    {
        return string.Compare(x.IngredientSO.Name,y.IngredientSO.Name);
    }

    public static int CompareByQuantity(IngredientItem x,IngredientItem y)
    {
        if (x.Quantity == y.Quantity)
        {
            return CompareByAttributeValue( x, y);
        }
        else if (x.Quantity < y.Quantity)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    public static int CompareByCategory(IngredientItem x,IngredientItem y)
    {
        return x.IngredientSO.Category.ToString().CompareTo(y.IngredientSO.Category.ToString());

    }

    public static int CompareByAttributeValue(IngredientItem x,IngredientItem y)
    {
        return x.IngredientSO.Attributes.Value.CompareTo(y.IngredientSO.Attributes.Value);
    }

}