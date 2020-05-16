using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;
    public SoundManager soundManager;
    public TimeManager timeManager;
    void Update(){
        if(soundManager.GetScoreCount() >= 10){
            Invoke("ChangeScene", 1.5f);
        }
        if(!player.activeInHierarchy){
            Invoke("ChangeScene", 1.5f);
        }
    }
    void ChangeScene(){
        SceneManager.sceneLoaded += ResultSceneLoaded;
        SceneManager.LoadScene("Result");
    }

    private void ResultSceneLoaded(Scene next, LoadSceneMode mode){
        var scoreManager = GameObject.Find("ResultManager").GetComponent<ResultScene>();
        scoreManager.score = soundManager.GetScoreCount();
        scoreManager.time = timeManager.GetTimeCount();
        SceneManager.sceneLoaded -= ResultSceneLoaded;
    }
}
