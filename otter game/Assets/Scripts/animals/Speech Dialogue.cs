using System.Collections.Generic;
using UnityEngine;

public class SpeechDialogue : MonoBehaviour
{
    [SerializeField] private int sizex = 0;
    [SerializeField] private int sizey = 0;
    [SerializeField] private List<BaseMaterial> materials = new List<BaseMaterial>();

    public void AddMaterial(BaseMaterial material)
    {
        materials.Add(material);
    }

    public void showMaterialsInBubble()
    {
        
    }
    
}
