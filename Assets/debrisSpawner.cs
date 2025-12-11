using UnityEngine;

public class debrisSpawner : MonoBehaviour
{
    public GameObject debrisPrefab;
    public int debrisAmount = 20;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnDebrisWave()
    {
        for (int i = 0; i < debrisAmount; i++)
        {
            Vector2 spawnpos = new Vector2(Random.Range(spawnAreaMin.x, spawnAreaMax.x), Random.Range(spawnAreaMin.y, spawnAreaMax.y));
            Instantiate(debrisPrefab, spawnpos, Quaternion.identity);   
        }
    }
}
