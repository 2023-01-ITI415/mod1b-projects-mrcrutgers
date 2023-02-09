using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
 

[RequireComponent( typeof( Rigidbody) )] // a 


public class Projectile : MonoBehaviour { 



const int LOOKBACK_COUNT = 10; // b | 
[SerializeField] > private bool _awake = true; // c 


public bool awake {
    get { return _awake; } 
    private set { _awake = value; } 
} 

private Vector3 prevPos; 
// This private List stores the history of Projectile’s move distance 
 private List < float > deltas = new List < float >(); 
 private Rigidbody rigid;

 void Start() { 
    rigid = GetComponent < Rigidbody >(); 
    awake = true; 
    prevPos = new Vector3( 1000,1000,0); // d 
    deltas.Add( 1000 );
    } 
    
void FixedUpdate() { 
    if ( rigid.isKinematic | | !awake ) return; // e 
                 
    Vector3 deltaV3 = transform.position - prevPos; // f 
    deltas.Add( deltaV3. magnitude ); 
    prevPos = transform.position; 
                 
    // Limit lookback; one of very few times that I’ll use while! // g 
    while ( deltas.Count > LOOKBACK_COUNT ) { 
        deltas.RemoveAt( 0 ); 
        } 
                     
// Iterate over deltas and find the greatest one 
float maxDelta = 0; 
foreach ( float f in deltas ) { 
    if ( f > maxDelta ) maxDelta = f; 
     } 
 // If the Projectile hasn’t moved more thanthan the sleepThreshold // h 
 if ( maxDelta < = Physics.sleepThreshold ) { 
// Set awake to false and put the Rigidbody to sleep 
    awake = false; 
    rigid.Sleep(); 
    } 
} | 
                          
}



}