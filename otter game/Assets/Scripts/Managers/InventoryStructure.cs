using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryStructure", menuName = "Scriptable Objects/InventoryStructure")]
public class InventoryStructure : ScriptableObject
{
    [SerializeField] private List<BaseMat> Hotbar = new List<BaseMat>();

    public void AddtoHotbat(BaseMat mat, int amount = 0)
    {
        Hotbar.Add(mat);
        Debug.Log(Hotbar[0].MaterialName);
    }
}
