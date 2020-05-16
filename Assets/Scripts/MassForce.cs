using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassForce : MonoBehaviour
{
    Vector3 gforce = new Vector3(0f, -8.0f, 0f);
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100.0f,0f,0f);
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)){
            rb.AddForce(gforce);
        }
    }
}
