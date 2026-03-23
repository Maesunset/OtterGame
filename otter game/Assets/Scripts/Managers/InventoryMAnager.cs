using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryStructure inventoryStructure;
    public WoodClass wood = new WoodClass();



    public static InventoryManager Instance;
    private void Awake()
    {

        // singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        wood.MaterialName = "paloTE de dani";
        AddToInventory(wood, 10);
    }
    private void Update()
    {
 
    }
    public void AddToInventory(BaseMat newMat, int amount)
    {
        inventoryStructure.AddtoHotbat(wood,amount);
    }
    public void RemoveFromInventory(BaseMaterial oldMath, int amount) 
    {
    
    }
}
