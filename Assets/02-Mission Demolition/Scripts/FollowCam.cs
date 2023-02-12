using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{


static private FollowCam S;
static public GameObject POI;

public enum eView { none, slingshot, castle, both };

 // The static point of interest // a 
    [Header("Inscribed")]
    public float easing = 0.05f;
    public Vector2 minXY = Vector2.zero;
    public GameObject viewBothGO;


    [Header("Dynamic")] 
    public float camZ; // The desired Z pos of the camera | 
    public eView nextView = eView.slingshot;

    void Awake() { 
        S = this;
        camZ = this.transform.position.z;
 } 

void FixedUpdate () { 
Vector3 destination = Vector3.zero; 
// b  
    if (POI != null) { // c 
// If the POI has a Rigidbody, check to see if it is sleeping 
    Rigidbody poiRigid = POI.GetComponent <Rigidbody>(); 
    if ((poiRigid != null) && poiRigid.IsSleeping()) { // d 
    POI = null; 
     } 
      } 
    if (POI != null) { // e 
    destination = POI.transform.position; 
    }

    destination.x = Mathf.Max(minXY.x, destination.x); 
    destination.y = Mathf.Max(minXY.y, destination.y);
    destination = Vector3.Lerp(transform.position, destination, easing);
    // Force destination.z to be camZ to keep the camera far enough away 
    destination.z = camZ; 
    // Set the camera to the destination 
    transform.position = destination; 
    Camera.main.orthographicSize = destination.y + 10;

}



public void SwitchView(eView newView) { // f
if (newView == eView.none) { 
    newView = nextView; 
 } 
switch (newView) { // g 
case eView.slingshot: 
    POI = null; 
    nextView = eView.castle; 
    break; 
case eView.castle: 
    POI = MissionDemolition.GET_CASTLE(); // h 
    nextView = eView.both; 
    break; 
case eView.both: 
    POI = viewBothGO; 
    nextView = eView.slingshot; 
    break; 
}

} 

public void SwitchView() { // i 
 SwitchView(eView.none); 
} 

static public void SWITCH_VIEW(eView newView) { // j 
    S.SwitchView(newView); 
    } 
}





