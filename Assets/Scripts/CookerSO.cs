using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Cooker", menuName = "Scriptable Objects/Cooker")]
public class CookerSO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite Sprite;
    [SerializeField] public CookingMethod CookingMethod;
    [SerializeField] public float MaxCharge;
    [SerializeField] public float AttributeLevelMultiplier;
    [SerializeField] public bool IsBurnable = true;
}


