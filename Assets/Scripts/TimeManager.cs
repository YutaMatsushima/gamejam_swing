using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float elapsedTime;
    public GameObject player;
    public Text timeText;
    void Start()
    {
        elapsedTime = 0;
    }

    void Update()
    {
        if(player.activeInHierarchy){
            elapsedTime += Time.deltaTime;
        }
        timeText.text = "Time: " + Mathf.FloorToInt((elapsedTime)).ToString();
    }

    public int GetTimeCount(){
        return Mathf.FloorToInt(elapsedTime);
    }
}
