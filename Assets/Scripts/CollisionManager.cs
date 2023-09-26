using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private LevelManager levelManager;
    [SerializeField] GameObject Player;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Respawn":
                Debug.Log("Start");
                break;
            case "Finish":
                Debug.Log("Finish");
                levelManager.SetPlayerFinished(gameObject.tag);
                gameObject.SetActive(false);
                break;
            case "Obstacle":
                Debug.Log("Obstacle");
                Destroy(Player);
                break;
            default:
                Debug.LogWarning("Unknown object");
                break;
        }


    }
}



