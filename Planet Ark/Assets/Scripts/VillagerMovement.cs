using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour {


    private Animator anim;

    public bool playerUp;
    public bool playerRight;
    public bool playerLeft;
    public bool playerDown;

    public float moveSpeed;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int WalkDirection; //walk
    
    private Rigidbody2D myRigidbody;


    // Use this for initialization
    void Start() {
        
        myRigidbody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {

        playerUp = false;
        playerRight = false;
        playerLeft = false;
        playerDown = false;

        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            

            //switch statment
            switch (WalkDirection)
            {
                case 0:
                    myRigidbody.velocity = new Vector2(0, moveSpeed);
                    playerUp = true;
                    break;

                case 1:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    playerRight = true;
                    break;

                case 2:
                    myRigidbody.velocity = new Vector2(0, -moveSpeed);
                    playerDown = true;
                    break;

                case 3:
                    myRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    playerLeft = true;
                    break;

            }
            if (walkCounter < 0)
            {
                isWalking = false;
                walkCounter = waitTime;
                
            }

        }
        else
        {
            waitCounter -= Time.deltaTime;

            myRigidbody.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }

        anim.SetBool("PlayerUp", playerUp);
        anim.SetBool("PlayerRight", playerRight);
        anim.SetBool("PlayerLeft", playerLeft);
        anim.SetBool("PlayerDown", playerDown);



    }
    public void ChooseDirection()      //walk  
    {
        WalkDirection = Random.Range (0,4); //Floats never pick the top number. 0-4 = 0,1,2,3.
        isWalking = true;
        walkCounter = waitTime;

       
    }


}
