using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private bool isWalking;
    private Animator _animator;
    private Rigidbody rigidBody;
    public bool canMove;

    void Start () 
    {
        _animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        canMove = true;
    }

    void Update () 
    {
        if(canMove == true)
        {
           isWalking = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            rigidBody.velocity += transform.right * Input.GetAxisRaw("Horizontal") * Speed;
            isWalking = true;
        }
        
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            rigidBody.velocity += transform.forward * Input.GetAxisRaw("Vertical") * Speed;
            isWalking = true;
        } 
        }       
        _animator.SetBool("IsWalking", isWalking);
}
}
