using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseAnimalPReferences", menuName = "Scriptable Objects/BaseAnimalPReferences")]
public class BaseAnimalPReferences : ScriptableObject
{
    [SerializeField] private string animalName;
    [SerializeField] private int animalID;
    [SerializeField] private int animalTradeProbability;
    [SerializeField] private int maxTradeItems;
    [SerializeField] private int minTradeItems;
    public List<BaseMaterial> animalLikes;
    public List<BaseMaterial> animalDislikes;
    public List<BaseMaterial> allTradePool;
    public List<BaseMaterial> preferencesPool;

    public string AnimalName
    {
        get
        {
            return animalName;
        }
    }

    public int AnimalID
    {
        get
        {
            return animalID;
        }
    }

    public int AnimalTradeProbability
    {
        get
        {
            return animalTradeProbability;
        }
    }

    public int MaxTradeItems
    {
        get
        {
            return maxTradeItems;
        }
    }    
    public int MinTradeItems
    {
        get
        {
            return minTradeItems;
        }
    }
    
}
