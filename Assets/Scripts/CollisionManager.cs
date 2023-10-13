using System.Collections;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private LevelManager levelManager;
    


    [SerializeField] GameObject Player;

    [SerializeField] ParticleSystem explosion;
    [SerializeField] AudioClip explosionSound;


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
                Expolosion();

                break;
            default:
                Debug.LogWarning("Unknown object");
                break;
        }
    }

    void Expolosion()
    {


        AudioSource.PlayClipAtPoint(explosionSound,transform.position);
        Instantiate(explosion, transform.position, Quaternion.identity);
        
    }
}





