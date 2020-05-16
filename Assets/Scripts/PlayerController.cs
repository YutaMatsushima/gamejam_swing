using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float scale = 0.03f;
    public GameObject pendulum;
    public Text scoreText;
    public Text winText;
    public int score;
    void start(){
        score = 0;
        SetCountText();
        winText.text = " ";
    }
    void Update()
    {
        Transform myTrans = this.transform;

        Vector3 localPos = myTrans.localPosition;
        localPos.y += scale * Input.GetAxis("Vertical");
        if(localPos.y < 0.8f && localPos.y > -1.1f){
            myTrans.localPosition = localPos;
        }
        SetCountText();
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Item")){
            other.gameObject.SetActive(false);
            score++;
            SetCountText();
        }
        if(other.gameObject.CompareTag("Danger")){
            pendulum.SetActive(false);
            winText.text = "Game Over...";
        }
    }

    void SetCountText(){
        scoreText.text = "Score: " + score.ToString();
        if(score >= 10){
            winText.text = "Clear!!";
        }
    }
}
