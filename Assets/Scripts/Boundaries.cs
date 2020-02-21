using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boundaries : MonoBehaviour
{
    public GameObject explosion, GameOver;
    public Text message;

    void Update()
    {

        if (transform.position.y == -4f || transform.position.y == 3f)
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            soundManager.PlaySound("explosion");
            message.text = "Game Over";
            gameObject.SetActive(false);
            GameOver.SetActive(true);
            Time.timeScale = 0f;
            
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 5.71f, 6f),
            Mathf.Clamp(transform.position.y, -4f, 3f),transform.position.z);

        
    }
}
