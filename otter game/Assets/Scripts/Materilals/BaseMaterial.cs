using UnityEngine;

[CreateAssetMenu(fileName = "BaseMaterial", menuName = "Scriptable Objects/BaseMaterial")]
public class BaseMaterial : ScriptableObject
{
    [SerializeField] private string materialName;
    [SerializeField] private int id;
    [SerializeField] private int materialAmount;
    [SerializeField] private int materialCost;
    [SerializeField] private Sprite materialSprite;

    public string MaterialName
    {
        get
        {
            return materialName;
        }
        set
        {
            materialName = value;
        }
    }

    public int MaterialAmount
    {
        get
        {
            return materialAmount;
        }
        set
        {
            materialAmount = value;
        }
    }
    public Sprite MaterialSprite
    {
        get
        {
            return materialSprite;
        }
    }

    public int ID
    {
        get
        {
            return id;
        }
    }
    public int MaterialCost
    {
        get
        {
            return materialCost;
        }
    }
}