using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25.0f;
    private readonly float xRange = 20.0f;
    private float zRange = 10.0f;
    private readonly float startPosition = 0.0f;
    
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement();
       FireProjectile();
    }

    private void PlayerMovement()
    {
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        } else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (verticalInput * speed * Time.deltaTime));
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
    }

    private void FireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
