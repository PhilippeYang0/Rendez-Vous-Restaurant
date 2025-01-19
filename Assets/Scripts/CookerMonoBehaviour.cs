using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Cooker : MonoBehaviour
{
    [SerializeField] public CookingMethod CookingMethod;

    public Food Cook()
    {
        return new PreparedIngredient(PreparationMethod,new List<Ingredient>(){ingredient});
    }

}