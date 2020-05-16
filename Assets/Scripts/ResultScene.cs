using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultScene : MonoBehaviour
{
    public int score;
    public int time;
    public Text scoreText;
    public Text timeText;
    void Start()
    {
        scoreText.text = "Your Score: " + score.ToString();
        timeText.text = "Your Time: " + time.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("Title");
        }
    }
}
