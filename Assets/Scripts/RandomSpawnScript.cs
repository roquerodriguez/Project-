using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{

    public GameObject prefab1, prefab2, prefab3, prefab4;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;

    private Vector2 screeenBound;

     void Start()
    {
        screeenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time> nextSpawn)
        {
            whatToSpawn = Random.Range(1, 5);
          

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;

                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;

                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;

                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;
        }


       
    }

   
}
