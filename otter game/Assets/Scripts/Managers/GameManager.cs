using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private int materialSelected;
    
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void ActualMaterial(int materialID)
    {
        if (materialID == materialSelected)
        {
            materialSelected = 0;
            Debug.Log("unselect Material");
        }
        else
        {
            materialSelected = materialID;
            Debug.Log("select new  Material");
        }
    }
}
