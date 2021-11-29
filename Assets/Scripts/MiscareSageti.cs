using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscareSageti : MonoBehaviour
{
    public float speed;
    float movementX;
    float movementY;

    public Camera cam;
    Vector2 mousePos;
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
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementY=10;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementY=-10;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementX=10;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementX=-10;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow))
        {
            movementY=0;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementX=0;
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg-90f;
        rb.rotation = angle;
    }
}
