using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int scorevalue = 0;
    public GameObject GameOver;
    private int maxScore = 1000;
    Text score;
    public Text message;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (scorevalue).ToString();
        if (scorevalue >= maxScore)
        {
            Time.timeScale = 0f;
            message.text = "You Won!";
            GameOver.SetActive(true);
        }
        else if(scorevalue < 0)
        {
            message.text = "Game Over!";
            Time.timeScale = 0f;
            GameOver.SetActive(true);
        }
    }
    public static void setScore(int s)
    {

        scorevalue += s;
    }

   
}
