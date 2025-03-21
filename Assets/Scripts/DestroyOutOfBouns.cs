using UnityEngine;

public class DestroyOutOfBouns : MonoBehaviour
{
    private float topBound = 30.0f;
    private float leftBound = -30.0f;
    private float rightBound = 30.0f;
    private float bottomBound = -10.0f;
    // private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
            // gameManager.AddLives(-1);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            // gameManager.AddLives(-1);
        }
    }
}