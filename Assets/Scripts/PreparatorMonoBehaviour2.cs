using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Preparator2 : Preparator
{
    public PreparedIngredient Prepare(Ingredient ingredient1,Ingredient ingredient2)
    {
        return new PreparedIngredient(PreparationMethod,new List<Ingredient>(){ingredient1,ingredient2});
    }
}
