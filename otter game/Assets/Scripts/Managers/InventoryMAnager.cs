using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryStructure inventoryStructure;
    public WoodClass wood = new WoodClass();



    public static InventoryManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
        
    }
    public void AddToInventory(BaseMat newMat, int amount)
    {

    }
    public void RemoveFromInventory(BaseMaterial oldMath, int amount) 
    {
    
    }
}