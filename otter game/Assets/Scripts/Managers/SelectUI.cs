using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using Unity.VisualScripting;

public class SelectUI : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private string tagToSelect;

    void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            if (results.Count > 0)
            {
                for(int i = 0;i < results.Count;i++)
                {
                    if (results[i].gameObject.CompareTag(tagToSelect))
                    {
                        if (results[i].gameObject.GetComponent<hotbarItem>())
                        {
                            GameManager.Instance.ActualMaterial(results[i].gameObject.GetComponent<hotbarItem>().GetID());
                        }
                    }
                }
            }
        }
    }

}
