using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float velocity= 500f;
    private Rigidbody2D rb;
    private Vector2 screeenBound;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-velocity*5,0);
        screeenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        soundManager.PlaySound("Lacer");

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > (screeenBound.x * 2))
        {
            Destroy(this.gameObject);
        }
    }

   
    

    
}
