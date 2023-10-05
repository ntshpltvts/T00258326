using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballcontrollscript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        collision.transform.position += Vector3.up;
    }

    internal void ImThrowingYou(HUmanControl hUmanControl)
    {
        transform.position = hUmanControl.transform.position + 2 * Vector3.up + 3 * hUmanControl.transform.forward;
       rb = GetComponent<Rigidbody>();
        rb.velocity = 10 * (2 * Vector3.up + 3 * hUmanControl.transform.forward);
    }
}
