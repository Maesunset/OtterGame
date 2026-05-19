using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField] private BaseAnimalPReferences preferences;
    [SerializeField] private Animator animalAnim;
    [SerializeField] private GameObject animalBubbleSpawn;

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

    public GameObject AnimalBubbleSpawn
    {
        get
        {
            return animalBubbleSpawn;
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
