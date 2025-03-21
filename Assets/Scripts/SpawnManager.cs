using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeY = 10;
    private float spawnPossZ = 20;
    private float startDelay = 0;
    private float spawnInterval = 2.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalFromTop", startDelay, Random.Range(spawnInterval, spawnInterval * 2));
        InvokeRepeating("SpawnRandomAnimalFromLeft", startDelay, Random.Range(spawnInterval, spawnInterval * 2));
        InvokeRepeating("SpawnRandomAnimalFromRight", startDelay, Random.Range(spawnInterval, spawnInterval * 2));
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void SpawnRandomAnimalFromTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoss = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            0,
            spawnPossZ
        );
            
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPoss,
            animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0)
        );
    }
    
    void SpawnRandomAnimalFromLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoss = new Vector3(
            -spawnRangeX,
            0,
            Random.Range(-spawnRangeY, spawnRangeY)
        );
            
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPoss,
            animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0)
        );
    }
    
    void SpawnRandomAnimalFromRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoss = new Vector3(
            spawnRangeX,
            0,
            Random.Range(-spawnRangeY, spawnRangeY)
        );
            
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPoss,
            animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0)
        );
    }
}
