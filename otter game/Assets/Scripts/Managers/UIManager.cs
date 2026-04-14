using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<Image> images = new List<Image>();
    [SerializeField] private List<TextMeshProUGUI> itemsAmount = new List<TextMeshProUGUI>();
    [SerializeField] private InventoryStructure structure;
    public static UIManager Instance;
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
        UpdateHotbar();
    }
    public void UpdateHotbar()
    {
        Debug.Log("1"); 
        Debug.Log(structure.InventoryCount());
        if(structure.InventoryCount() == 0) return;
        Debug.Log("2"); 

        for(int i = 0;i < structure.InventoryCount(); i++ )
        {
            Debug.Log("I:" + i); 
            if(i >= images.Count) break;
            images[i].sprite = structure.inventorySprite(i); 
        }
    }
}
