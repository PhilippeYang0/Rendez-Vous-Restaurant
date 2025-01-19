using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class PreparedIngredient
{
    public PreparationMethod PreparationMethod;
    public List<Ingredient> Ingredients;
    public string Name => FoodSystemStaticFields.PreperationMethodNameDictionary[PreparationMethod];
    public Sprite Sprite
    {
        get
        {
            if (PreparationMethod == PreparationMethod.Chopped)
            {
                return FoodSystemStaticFields.ChoppedIngredientCategorySpriteDictionary[Ingredients[0].IngredientSO.Category];
            }
            else
            {
                return FoodSystemStaticFields.PreparationMethodSpriteDictionary[PreparationMethod];
            }
        }
    }
    public PreparedIngredient(PreparationMethod preparationMethod,List<Ingredient> ingredients)
    {
        PreparationMethod = preparationMethod;
        Ingredients = ingredients;
    }
}