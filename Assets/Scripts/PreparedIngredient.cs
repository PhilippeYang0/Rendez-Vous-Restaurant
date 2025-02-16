using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class PreparedIngredient
{
    public PreparationMethod PreparationMethod;
    public List<IngredientSO> Ingredients;
    public string Name => FoodSystemStaticFields.PreperationMethodNameDictionary[PreparationMethod];
    public Sprite Sprite
    {
        get
        {
            if (PreparationMethod == PreparationMethod.Chopped)
            {
                return FoodSystemStaticFields.ChoppedIngredientCategorySpriteDictionary[Ingredients[0].Category];
            }
            else
            {
                return FoodSystemStaticFields.PreparationMethodSpriteDictionary[PreparationMethod];
            }
        }
    }
    public PreparedIngredient(PreparationMethod preparationMethod,List<IngredientSO> ingredients)
    {
        PreparationMethod = preparationMethod;
        Ingredients = ingredients;
    }
}
