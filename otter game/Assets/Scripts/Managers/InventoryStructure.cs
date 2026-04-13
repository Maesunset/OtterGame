using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryStructure", menuName = "Scriptable Objects/InventoryStructure")]
public class InventoryStructure : ScriptableObject
{
    [SerializeField] private List<BaseMaterial> Hotbar = new List<BaseMaterial>();

    public void AddtoHotbat(BaseMaterial mat)
    {
        Hotbar.Add(mat);
        Debug.Log(Hotbar[0].MaterialName);
        UIManager.Instance.UpdateHotbar();
    }
}
