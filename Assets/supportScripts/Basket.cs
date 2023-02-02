using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class Basket : MonoBehaviour { 
     void Start () {} // We’ll add code to Start() in Code Listing 29.12


    void Update () {
    // Get the current screen position of the mouse from Input
    Vector3 mousePos2D = Input.mousePosition;
    mousePos2D.z = -Camera.main.transform.position.z;
    Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );
    Vector3 pos = this.transform.position; 
    pos.x = mousePos3D.x; 
    this.transform.position = pos;
    }

    void OnCollisionEnter( Collision coll ) { 
        GameObject collidedWith = coll.gameObject;
        if ( collidedWith.CompareTag("Apple") ) {
             Destroy( collidedWith ); 
             }
     }
 


 }

