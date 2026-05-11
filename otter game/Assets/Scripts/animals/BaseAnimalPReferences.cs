using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseAnimalPReferences", menuName = "Scriptable Objects/BaseAnimalPReferences")]
public class BaseAnimalPReferences : ScriptableObject
{
    public string animalName;
    public int animalID;
    public List<BaseMaterial> animalLikes;
    public List<BaseMaterial> animalDislikes;
    public List<BaseMaterial> allTradePool;
    public List<BaseMaterial> preferencesPool;

    
    
}
