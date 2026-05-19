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
}
