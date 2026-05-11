using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AnimalsBiomeList", menuName = "Scriptable Objects/AnimalsBiomeList")]
public class AnimalsBiomeList : ScriptableObject
{
    [SerializeField] private int rareProbability;
    [SerializeField] private List<GameObject> biomeAnimals;
    [SerializeField] private List<GameObject> rareAnimalsList;
}
