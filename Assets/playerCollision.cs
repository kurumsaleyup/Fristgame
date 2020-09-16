using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    //reference to playermovement function
    public playerMovement movement;

    //spesific function that unity created for collisions
    void OnCollisionEnter (Collision collisionInfo) //information about collision
    {
        //Debug.Log(collisionInfo.collider.name); // to display what we hit. This clould be buggy so we use "tags"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;//when crashed with and obstacle tag, kills the movement.
            //Debug.Log(collisionInfo.collider.name);
            Debug.Log("Movement disabled");
        }



    }
}
