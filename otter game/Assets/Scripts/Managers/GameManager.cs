using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Dictionary<int, int> scaleValues = new Dictionary<int, int>();
    [SerializeField] private InventoryStructure inventoryStructure;
    [SerializeField] private int internalValue = 0;

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

    public void LoadMaterial(int MaterialID)
    {
        if(scaleValues.TryGetValue(MaterialID, out var value))
        {
            value++;
            scaleValues[MaterialID] = value;
        }
        else
        {
            scaleValues[MaterialID] = 1;
        }
        UpdateInternalValue();
    }

    public void UnloadMaterial(int MaterialID)
    {
        if (scaleValues.TryGetValue(MaterialID, out var value))
        {
            value--;
            if(value == 0)
            {
                scaleValues.Remove(MaterialID);
            }
            else
            {
                scaleValues[MaterialID] = value;
            }
        }
        else
        {
            Debug.Log("no material ");
        }
        UpdateInternalValue();
    }
    public void ResetDictionary()
    {
        scaleValues = new Dictionary<int, int>();
    }
    public void UpdateInternalValue()
    {
        int tempValue;
        internalValue = 0;
        // debug all prosibilities
        foreach(var values in scaleValues)
        {
            
            Debug.Log(values);
        }

        for(int i = 1;i<=inventoryStructure.AllmaterialsCount() ;i++)
        {
            if(scaleValues.TryGetValue(i, out int amount))
            {
                tempValue = inventoryStructure.AllMaterialsCost(i) * amount;
                internalValue += tempValue;
            }
        }

    }
}
