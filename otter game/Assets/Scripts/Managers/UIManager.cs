using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //  hotbar
    public List<GameObject> images = new List<GameObject>();
    // texto en la hotbar
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
        int temp = 1;
        foreach (var image in images)
        {
            image.GetComponent<Image>().sprite = structure.inventorySprite(temp);
            image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            image.GetComponent<hotbarItem>().saveID(structure.InventoryID(temp));
            itemsAmount[temp-1].text = structure.InventoryAmount(temp).ToString();
            temp++;
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
