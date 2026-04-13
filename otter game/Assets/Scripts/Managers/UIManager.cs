using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> images;
    [SerializeField] private List<TextMeshProUGUI> itemsAmount;
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
    }
    public void UpdateHotbar()
    {
        
    }
}
