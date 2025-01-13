using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coincollector : MonoBehaviour
{
    private Animator _animator;
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.TryGetComponent<Icollectable>(out Icollectable icoll))
        {
            icoll.OnCollected();
            _animator.SetTrigger("GetCoin");
            _animator.SetLayerWeight(1, 1);
            GetComponent<PlayerController>().canMove = false;
        }
        
    }
}   
