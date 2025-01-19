using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Preparator", menuName = "Scriptable Objects/Preparator")]
public class PreparatorSO : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public Sprite Sprite;
    [SerializeField] public PreparationMethod PreparationMethod;
    [SerializeField] public float MaxCharge;
    [SerializeField] public float AttributeLevelMultiplier;
    [SerializeField] public bool IsAutomated = false;
}


