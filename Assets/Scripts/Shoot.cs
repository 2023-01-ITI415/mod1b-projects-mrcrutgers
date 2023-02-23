using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
// Hint: By making the prefab field Rigidbody you later can skip GetComponent
    public Rigidbody applePrefab;
    public float shootSpeed = 300;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootBullet();
        }
    }

    void shootBullet()
    {
        // Instantiate a new bullet at the players position and rotation
        var projectile = Instantiate (applePrefab, transform.position, transform.rotation);

        //Shoot the Bullet in the forward direction of the player


        //projectile.velocity = transform.TransformDirection( Vector3 ( 0, 0, shootSpeed) );
        //transform.forward * shootSpeed;
    }
}


var force: float;

//or should i do it like this?


// function Update(){ 
//     if(Input.GetMouseButtonDown(0)){
//     applePrefab.rigidbody.AddForce(applePrefab.transform.forward, applePrefab.rigidbody.mass force, ForceMode.Impulse);
//     }
// }