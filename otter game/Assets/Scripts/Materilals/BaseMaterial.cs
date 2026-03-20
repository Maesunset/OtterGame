using UnityEngine;

[CreateAssetMenu(fileName = "BaseMaterial", menuName = "Scriptable Objects/BaseMaterial")]
public class BaseMaterial : ScriptableObject
{
    [SerializeField] private string materialName;
    [SerializeField] private int materialStackAmount;
    [SerializeField] private int materialAmount;
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

    public int MaterialStackAmount
    {
        get
        {
            return materialStackAmount;
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

}
