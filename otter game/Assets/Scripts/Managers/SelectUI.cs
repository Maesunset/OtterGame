using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class SelectUI : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private string tagToSelect;

    void Update()
    { 
        // click Derecho
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
                            GameManager.Instance.LoadMaterial(results[i].gameObject.GetComponent<hotbarItem>().GetID());
                        }
                    }
                }
            }
        }
        // click izquierdo
        if (Input.GetMouseButtonDown(1))
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
                            GameManager.Instance.UnloadMaterial(results[i].gameObject.GetComponent<hotbarItem>().GetID());

                        }
                    }
                }
            }
        }
    }

}
