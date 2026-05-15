using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<GameObject> images = new List<GameObject>();
    public List<TextMeshProUGUI> itemsAmount;
    [SerializeField] private InventoryStructure structure;
    public static UIManager Instance;
    [SerializeField] private GameObject hotbar;
    [SerializeField] private bool isActive = false; 

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
    public void UpdateHotbar()
    {
        if(structure.InventoryCount() == 0) return;
        for(int i = 0;i < structure.InventoryCount(); i++ )
        {
            if(i >= images.Count) break;
            images[i].GetComponent<Image>().sprite = structure.inventorySprite(i); 
            images[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            images[i].GetComponent<hotbarItem>().saveID(structure.InventoryID(i));
            itemsAmount[i].text = structure.InventoryAmount(i).ToString();
            
        }
    }

    public void triggerHotbar()
    {
        if(isActive)
        {
            hotbar.SetActive(false);
            isActive = false;
        }
        else
        {
            hotbar.SetActive(true);
            isActive = true;
        }
    }
}
