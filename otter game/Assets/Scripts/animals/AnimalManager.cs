using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField] private BaseAnimalPReferences preferences;
    [SerializeField] private Animator animalAnim;
    [SerializeField] private GameObject speechDialgue;

    public string AnimalName()
    {
        return preferences.name;
    }

    public BaseAnimalPReferences Preferences
    {
        get
        {
            return preferences;
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
    
    public void VisualizeDialogue()
    {
        speechDialgue.SetActive(true);
        if (speechDialgue.TryGetComponent<SpeechDialogue>(out SpeechDialogue speech))
        {
            speech.showMaterialsInBubble();
        }
    }

    public void AddToDialgue(BaseMaterial material)
    {
        if (speechDialgue.TryGetComponent<SpeechDialogue>(out SpeechDialogue speech))
        {
            speech.AddMaterial(material);
        }
            
    }
}
