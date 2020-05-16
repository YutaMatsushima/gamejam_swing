using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public float offset = 0.8f;
    private Vector3 itempos;
    private int pattern;
    void Start(){
        itempos = transform.position;
        pattern = Random.Range(0, 3);
    }
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 45) * Time.deltaTime);

        if(pattern == 0){
            transform.position = new Vector3(Mathf.Sin(Time.time)*offset + itempos.x, itempos.y, itempos.z);
        }else if(pattern == 1){
            transform.position = new Vector3(Mathf.Sin(Time.time*(-1))*offset + itempos.x, itempos.y, itempos.z);
        }else if(pattern == 2){
            transform.position = new Vector3(Mathf.Cos(Time.time)*offset + itempos.x, itempos.y, itempos.z);
        }
    }
}
