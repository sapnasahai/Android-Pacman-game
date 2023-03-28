using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGo : MonoBehaviour
{
    Rigidbody rb;

    public bool moveRight;
    public bool moveLeft;
    public bool moveForward;
    public bool moveBackward;

    public float horizontalMove;
    public float verticalMove;

    public float playerSpeed = 100f;

    public Color whitecolor;

    public GameObject panel;
    public GameObject winpanel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void PointerDownR()
    {
        moveRight = true;
    }

    public void PointerUpR()
    {
        moveRight = false;
    }
    public void PointerDownL()
    {
        moveLeft = true;
    }

    public void PointerUpL()
    {
        moveLeft = false;
    }
    public void PointerDownF()
    {
        moveForward = true;
    }

    public void PointerUpF()
    {
        moveForward = false;
    }
    public void PointerDownB()
    {
        moveBackward = true;
    }

    public void PointerUpB()
    {
        moveBackward = false;
    }



    private void Update()
    {
        playerMovement();
    }

    private void playerMovement()
    {
        if (moveRight)
        {
            horizontalMove = playerSpeed;
        }
        else if (moveLeft)
        {
            horizontalMove = -playerSpeed;
        }
        else
        {
            horizontalMove = 0;
        }

        if (moveForward)
        {
            verticalMove = playerSpeed;
        }
        else if (moveBackward)
        {
            verticalMove = -playerSpeed;
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
        if(other.gameObject.tag == "green")
        {
            Destroy(gameObject);
            Debug.Log("destroy");
            panel.SetActive(true);
        }


        if (other.gameObject.tag == "white")
        {
            transform.GetComponent<Renderer>().material.color = whitecolor;
            Debug.Log("You win the game");
            winpanel.SetActive(true);
        }
        


    }







}
