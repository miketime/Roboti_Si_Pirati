using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscareWASD : MonoBehaviour
{
    public float speed;
    float movementX;
    float movementY;
    public Animator animator;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        movementX=0;
        movementY=0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=new Vector2(movementX*speed*Time.deltaTime,movementY*speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.W))
        {
            movementY=10;
            animator.SetBool("mers", true);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            movementY=-10;
            animator.SetBool("mers", true);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            movementX=10;
            animator.SetBool("mers", true);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            movementX=-10;
            animator.SetBool("mers", true);
        }
        if(Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.S))
        {
            movementY=0;
           
        }
        if(Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D))
        {
            movementX=0;
         
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
         
            animator.SetBool("mers", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            animator.SetBool("mers", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            animator.SetBool("mers", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            animator.SetBool("mers", false);
        }

    }
}
