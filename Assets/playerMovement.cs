//using System.Collections;
//using System.Collections.Generic;
//Apparently these aren't needed currently.
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //This is run at the very beginning so it's the way of initilialzing objects before the game starts
    // Start is called before the first frame update
    /*void Start()
    {
        //Debug.Log("Hello World");
    }*/

    //So is this an object?
    //I assume C# is object oriented???
    public Rigidbody rb;


    //Update() is called every frame

    //Unity script starts us off with Update(), but the tutorial asks me to use FixedUpdate()
    //b/c it's better with physics apparently?
    //Look up why this would be the case

    // Update is called once per frame
    void FixedUpdate()
    {
        /*deltaTime basically measures based on framerate.
        Currently, FixedUpdate is called on every frame which means those with higher framerates have a better advantage
        We can mitigate this by using deltaTime which gives us a consistent point in time for us to measure instead of relying on framerate
        The point of math here gives us that:
        If we have 10 frames a second, deltaTime is .1
        If we have 20 frames a second, deltaTime is .05
        */
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
