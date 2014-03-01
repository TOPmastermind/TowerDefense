using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

    // Config
    public float spawnTime;
    public float spawnDelay;
    public GameObject[] enemies;

	// Use this for initialization
	void Start () 
    {
	    // Star calling the spawn function after delay
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    // Instantiate a random enemy

	}

    void Spawn() 
    {
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies [enemyIndex], transform.position, transform.rotation);
    }
      
}
