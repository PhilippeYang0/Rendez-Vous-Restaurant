using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient")]
public class IngredientSO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite Sprite;
    [SerializeField] public Category Category;
    [SerializeField] public Attributes Attributes;
}


