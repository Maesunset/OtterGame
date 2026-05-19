using System;
using System.Collections.Generic;
using UnityEngine;

public class SpeechDialogue : MonoBehaviour
{
    [SerializeField] private float sizex = 0;
    [SerializeField] private float sizey = 0;
    [SerializeField] private List<BaseMaterial> materials = new List<BaseMaterial>();
    private Dictionary<BaseMaterial, int> speechDictionary = new Dictionary<BaseMaterial, int>();

    public void AddMaterial(BaseMaterial material)
    {
        materials.Add(material);
        if(speechDictionary.TryGetValue(material, out int materialId))
        {
            materialId++;
            speechDictionary[material] = materialId;
        }
        else
        {
            speechDictionary.Add(material,1);
        }
    }
    
    public void ResetSpeech()
    {
         speechDictionary.Clear();
         materials.Clear();
    }

    public void showMaterialsInBubble()
    {
        foreach (BaseMaterial material in speechDictionary.Keys)
        {
            Debug.Log(material +  " " + speechDictionary[material]);
        }
    }
}