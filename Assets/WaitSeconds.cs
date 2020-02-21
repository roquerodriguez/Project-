using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitSeconds : MonoBehaviour
{
    public int IsRunning = 1;
    public int NumberofSeconds;

    // Update is called once per frame
    void Update()
    {
        if(IsRunning == 1)
        {
            StartCoroutine(Wait());
        }
       
    }

    public IEnumerator Wait()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        Scoring.setScore(-5);
        IsRunning = 1;
    }
    
}
