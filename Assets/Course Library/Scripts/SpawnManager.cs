using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private const float xRange = 10;
    private const float spawnPointZ = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            int randimal = Random.Range(0, animals.Length);
            Instantiate(animals[randimal], new Vector3(Random.Range(-xRange, xRange), 0, spawnPointZ), animals[randimal].transform.rotation);
        }
    }
}
