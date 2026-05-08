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
            Debug.Log("new new value of material:");
        }
        else
        {
            scaleValues[MaterialID] = 1;
            Debug.Log("add new material to scale");
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
                Debug.Log("material removed");
            }
            else
            {
                scaleValues[MaterialID] = value;
                Debug.Log(" new value of material: " + value);
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
        foreach(var values in scaleValues)
        {
            print(values);
        }

    }
}
