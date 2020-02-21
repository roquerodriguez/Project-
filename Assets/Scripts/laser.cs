using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laser : MonoBehaviour
{
    public GameObject explosion;
    public static int add= 0;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detected: "+ other.name);
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        soundManager.PlaySound("explosion");
        switch (other.name)
        {
            case "BluePrefab(Clone)":
                add = 10;
                Scoring.setScore(add);
                break;
            default:
                add = 5;
                Scoring.setScore(add);
                break;
        }
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        

        
    }
   
}
