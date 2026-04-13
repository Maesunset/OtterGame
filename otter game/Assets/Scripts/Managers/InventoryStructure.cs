using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "InventoryStructure", menuName = "Scriptable Objects/InventoryStructure")]
public class InventoryStructure : ScriptableObject
{
    [SerializeField] private List<BaseMaterial> inventory = new List<BaseMaterial>();

    public int InventoryCount()
    {
        return inventory.Count;
    }

    public Sprite inventorySprite(int index)
    {
        return inventory[index].MaterialSprite;
    }

}
