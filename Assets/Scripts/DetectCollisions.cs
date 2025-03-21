using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Check if the other tag was the Player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        //Check if the other tag was an Animal, if so add points to the score
        else if (other.CompareTag("Projectile"))
        {
            gameManager.AddScore(5);
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(other.gameObject);
            // Destroy(gameObject);
        }
    }


    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Animal"))
    //     {  
    //         // Debug.Log("Game Over!");
    //         gameManager.AddLives(-1);
    //         Destroy(gameObject);
    //     } else if (gameObject.CompareTag("Animal") && other.gameObject.CompareTag("Projectile"))
    //     {
    //         // gameManager.AddScore(5);
    //         other.GetComponent<AnimalHunger>().FeedAnimal(1);
    //         Destroy(gameObject);
    //         // Destroy(other.gameObject);
    //     }
    // }
}
