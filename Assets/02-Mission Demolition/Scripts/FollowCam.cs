using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    static public GameObject POI; // The static point of interest // a 
    [Header(" Inscribed")]
    public float easing = 0.05f;
    public Vector2 minXY = Vector2. zero;



    [Header(" Dynamic")] 
    public float camZ; // The desired Z pos of the camera | 
    void Awake() { 
        camZ = this.transform.position.z;
 } 
void FixedUpdate () { 
    // A single-line if statement doesn’t require braces 
    if (POI == null) return; // if there is no POI, then return // b 
 
    // Get the position of the poi 
    Vector3 destination = POI.transform.position; 
    destination.x = Mathf.Max( minXY.x, destination.x ); 
    destination.y = Mathf.Max( minXY.y, destination.y );


    destination = Vector3. Lerp( transform.position, destination, easing);
    // Force destination.z to be camZ to keep the camera far enough away 
    destination.z = camZ; 
    // Set the camera to the destination 
    transform.position = destination; 
    Camera.main.orthographicSize = destination.y + 10;

    }



}

