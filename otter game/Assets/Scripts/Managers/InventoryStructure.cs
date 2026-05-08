using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryStructure", menuName = "Scriptable Objects/InventoryStructure")]
public class InventoryStructure : ScriptableObject
{
    [SerializeField] private List<BaseMaterial> allMaterials = new List<BaseMaterial>();
    [SerializeField] private List<BaseMaterial> inventory = new List<BaseMaterial>();

    public int InventoryCount()
    {
        return inventory.Count;
    }

    public Sprite inventorySprite(int index)
    {
        return inventory[index].MaterialSprite;
    }
    
    public int InventoryAmount(int index)
    {
        return inventory[index].MaterialAmount;
    }

    public int InventoryID(int index)
    {
        return inventory[index].ID;
    }
    public int AllMaterialsCost(int ID)
    {
        foreach (BaseMaterial material in allMaterials)
        {
            if (material.ID == ID)
            {
                return material.MaterialCost;
            }
        }
        return 0;   
    }
}
