using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownTimer : MonoBehaviour
{
    public float timestart = 300.0f;
    public Text textBox, Game;
    public GameObject GameOver;
    string tiempo;

    void start()
    {
        textBox.text = ConvertFromSecToMin(timestart);
    }
    void Update()
    {
        timestart -= Time.deltaTime;
        textBox.text =ConvertFromSecToMin(Mathf.Round(timestart));
        if( timestart <=0)
        {
            textBox.text = "0";
            Time.timeScale = 0f;
            Game.text = "GAME OVER";
            GameOver.SetActive(true);
        }
    }
    string ConvertFromSecToMin(float time)
    {
        int min =  (int)time/ 60;
        int resting = (int)time % 60;

        if (min==0 && resting <= 9)
        {
            tiempo = "0" + resting;
        }
        else if (min == 0 && resting >=10)
        {
            tiempo = resting.ToString();
        }
        else if(min>0 && resting <= 9)
        {
            tiempo = min + ":0" + resting;
        }
        else 
        {
            tiempo = min + ":" + resting;

        }

        return tiempo;
    }
}
