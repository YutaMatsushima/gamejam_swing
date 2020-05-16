using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    public GameObject Player;
    PlayerController script;
    private int prescore;
    private bool flag;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        script = Player.GetComponent<PlayerController>();
        prescore = 0;
        flag = true;
    }

    void Update()
    {
        if(prescore != script.score){
            audioSource.PlayOneShot(sound1);
            prescore = script.score;
        }

        if(!Player.activeInHierarchy && flag){
            audioSource.PlayOneShot(sound2);
            flag = false;
        }
    }

    public int GetScoreCount(){
        return prescore;
    }
}
