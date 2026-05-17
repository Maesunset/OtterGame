using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryStructure inventoryStructure;
    public static InventoryManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartDebuging();
        UpdateHotbar();
    }

    private void StartDebuging()
    {
        for (int i =0;i<= inventoryStructure.InventoryCount();i++)
        {
            inventoryStructure.UpdateMaterialValues(i,10);
        }
    }
    public void AddToInventory(int itemID, int itemAmount)
    {
        int temp = inventoryStructure.InventoryAmount(itemID);
        temp += itemAmount;
        inventoryStructure.UpdateMaterialValues(itemID, temp);
        UpdateHotbar();
    }
    public void RemoveFromInventory(int itemID, int itemAmount) 
    {
        int temp = inventoryStructure.InventoryAmount(itemID);
        temp -= itemAmount;
        inventoryStructure.UpdateMaterialValues(itemID, temp);
        UpdateHotbar();
    }

    private void UpdateHotbar()
    {
        UIManager.Instance.UpdateHotbar();
    }
}