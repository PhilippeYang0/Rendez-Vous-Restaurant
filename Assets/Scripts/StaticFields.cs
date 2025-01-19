using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class FoodSystemStaticFields : MonoBehaviour
{
    [SerializeField] static public Dictionary<PreparationMethod,string> PreperationMethodNameDictionary;
    [SerializeField] static public Dictionary<PreparationMethod,Sprite> PreparationMethodSpriteDictionary;
    [SerializeField] static public Dictionary<Category,Sprite> ChoppedIngredientCategorySpriteDictionary;
    [SerializeField] static public List<IngredientSO> IngredientSOs;
    [SerializeField] static public List<FoodSO> FoodSOs;

}
