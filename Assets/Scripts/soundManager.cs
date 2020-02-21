using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip laser, explosion;
    static AudioSource audioSourceC;

    // Start is called before the first frame update
    void Start()
    {
        laser = Resources.Load<AudioClip>("Laser");
        explosion = Resources.Load<AudioClip>("Explosion");

        audioSourceC = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Lacer":
                audioSourceC.PlayOneShot(laser);
                break;
            default:
                audioSourceC.PlayOneShot(explosion);
                break;
        }
    }
}
