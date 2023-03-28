using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerCont : MonoBehaviour
{

    Rigidbody rb;
    public Color yellowcolor;
    public float redSpeed = 10f;


    public bool moveRight;
    public bool moveLeft;
    public bool moveForword;
    public bool moveBackword;
    float horizontalMove;
    float verticalMove;


    public GameObject panel;
    public GameObject winPanel;
    
    /* void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(redSpeed * Vector3.left * Time.deltaTime); 
           
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(redSpeed * Vector3.right * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(redSpeed * Vector3.back * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(redSpeed * Vector3.forward * Time.deltaTime);

        }
    }
   */





    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // for left button checked is being pressed or not ?

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    // right button is pressed or not ?
    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }


    // forword button is pressed or not?
    public void PointerDownForword()
    {
        moveForword = true;
    }
    public void PointerUpForword()
    {
        moveForword = false;
    }


    // backword button is pressed or not?
    public void PointerDownBakword()
    {
        moveBackword = true;
    }
    public void PointerUpBackword()
    {
        moveBackword = false;
    }


    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (moveRight)
        {
            horizontalMove = redSpeed;
        }
        else if (moveLeft)
        {
            horizontalMove = -redSpeed;
        }
        else
        {
            horizontalMove = 0;
        }

        if (moveForword)
        {
            verticalMove = redSpeed;
        }
        else if (moveBackword)
        {
            verticalMove = -redSpeed;
        }
        else
        {
            verticalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalMove * Time.deltaTime, rb.velocity.y, verticalMove * Time.deltaTime);
    }




    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "destroy")
        {
            Destroy(gameObject);
            panel.SetActive(true);
        }


        if (other.gameObject.tag == "yellow")
        {
            transform.GetComponent<Renderer>().material.color = yellowcolor;
            Debug.Log("yellow");
            winPanel.SetActive(true);
        }



    }

    

}
