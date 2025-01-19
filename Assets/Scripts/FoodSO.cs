using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Food", menuName = "Scriptable Objects/Food")]
public class FoodSO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite Sprite;
    [SerializeField] public List<PreparedIngredient> NeededPreparedIngredient;
    [SerializeField] public List<IngredientSO> NeededIngredients;
    [SerializeField] public List<Category> NeededCategories;
}


