using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject   applePrefab;

    // Speed at which the AppleTree moves
    public float        speed = 1f;

    // Distance where AppleTree turns around
    public float        leftAndRightEdge = 20f;

    // Chance that the AppleTree will change di
    public float        chanceToChangeDirection = 0.1f;

    // Rate at which Apples will be instantiate
    public float        appleDropDelay = 1f;

    void Start () {
        // Dropping apples every second
         Invoke( "DropApple", 2f );  
    }

    void DropApple() {                         
        
        GameObject apple = Instantiate < GameObject >( applePrefab );
        apple.transform.position = transform.position; 
        Invoke( "DropApple", appleDropDelay );

    }


    void Update () {
        // Basic Movement
        Vector3 pos = transform.position;      
        pos.x += speed * Time.deltaTime;       
        transform.position = pos; 
        // Changing Direction
        if ( pos.x < -leftAndRightEdge ) {      
           speed = Mathf.Abs(speed); // Move ri
       } else if ( pos.x > leftAndRightEdge ) {
           speed = -Mathf.Abs(speed); // Move l
       }
    }

    void FixedUpdate() {
        if ( Random.value < chanceToChangeDirection ){
           speed *= -1; // Change direction   
       }
    }




    
}