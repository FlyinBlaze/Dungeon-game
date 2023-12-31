using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    //Variable for our speed modifier
    public float moveSpeed;
    //Variable for our player input
    public Vector2 movementInput;
    //Variable for our RigidBody2D
    public Rigidbody2D rigidBody;

    //Variable  for Animator
    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //While S is pressed run this animation
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("forwardAnimation");

        }
        if (Input.GetKeyUp(KeyCode.S))
        {


        }
        //While W is pressed run this animation
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("backwardAnimation");

        }
        if (Input.GetKeyUp(KeyCode.W))
        {


        }
        //While A is pressed run this animation
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("leftAnimation");

        }
        if (Input.GetKeyUp(KeyCode.A))
        {


        }
        //While D is pressed run this animation
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("rightAnimation");

        }
        if (Input.GetKeyUp(KeyCode.D))
        {


        }



    }

    //Update that handles physics
    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    //Converts our Inputs to Vector
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }

}