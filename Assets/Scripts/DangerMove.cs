using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerMove : MonoBehaviour
{
    public float offset = 2.0f;
    private Vector3 dangerpos;
    private int pattern;
    void Start(){
        dangerpos = transform.position;
        pattern = Random.Range(0, 3);
    }
    void Update()
    {
        transform.Rotate(new Vector3(15f, 30f, 45f) * Time.deltaTime);

        if(pattern == 0){
            transform.position = new Vector3(dangerpos.x, Mathf.Sin(Time.time*2)*offset + dangerpos.y, dangerpos.z);
        }else if(pattern == 1){
            transform.position = new Vector3(dangerpos.x, Mathf.Sin(Time.time*(-2))*offset + dangerpos.y, dangerpos.z);
        }else if(pattern == 2){
            transform.position = new Vector3(dangerpos.x, Mathf.Cos(Time.time*2)*offset + dangerpos.y, dangerpos.z);
        }
    }
}
