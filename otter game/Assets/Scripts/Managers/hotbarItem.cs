using UnityEngine;

public class hotbarItem : MonoBehaviour
{
    [SerializeField] private int currentItemID;

    public void saveID(int newID)
    {
        currentItemID = newID;
    }

    public int GetID()
    {
        return currentItemID;
    }

}
