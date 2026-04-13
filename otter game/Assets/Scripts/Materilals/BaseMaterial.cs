using UnityEngine;

[CreateAssetMenu(fileName = "BaseMaterial", menuName = "Scriptable Objects/BaseMaterial")]
public class BaseMaterial : ScriptableObject
{
    [SerializeField] private string materialName;
    [SerializeField] private int id;
    [SerializeField] private int materialAmount;
    [SerializeField] private Sprite materialSprite;
    [SerializeField] private BaseMat matClass;

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
    }
    public Sprite MaterialSprite
    {
        get
        {
            return materialSprite;
        }
    }

}