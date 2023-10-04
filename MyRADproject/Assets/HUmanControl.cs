using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUmanControl : MonoBehaviour
{
    public GameObject snowballCloneTemplate;
    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    private float turningSpeed = 180;
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;
        myAnimator = GetComponent<Animator>();  
        
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetBool("is walking", false);
        if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetBool("is walking", true);
            transform.position += transform.forward * Time.deltaTime;

        }
         if (Input.GetKey(KeyCode.S))

        {
            myAnimator.SetBool("is walking", true);
            transform.position -= currentSpeed * transform.forward * Time.deltaTime;    
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.A)) 
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }

        if (Input.GetMouseButton(0))
        {
            Instantiate(snowballCloneTemplate);
            GameObject newGO = Instantiate(snowballCloneTemplate);
            snowballcontrollscript mySnowball = newGO.GetComponent<snowballcontrollscript>();

            mySnowball.ImThrowingYou(this);
        }
    }
}
