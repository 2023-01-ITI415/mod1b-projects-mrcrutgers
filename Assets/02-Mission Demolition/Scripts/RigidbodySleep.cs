using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySleep : MonoBehaviour
{
   

[RequireComponent( typeof( Rigidbody) )] // a 

public class RigidbodySleep : MonoBehaviour { 

private int sleepCountdown = 4;


private Rigidbody rigid; 


void Awake() { 
    rigid = GetComponent < Rigidbody >(); // c 
    } | 
    void FixedUpdate() { 
        if ( sleepCountdown > 0 ) { // d 
        rigid.Sleep(); 
        sleepCountdown--; 
        } 
    }


}

}