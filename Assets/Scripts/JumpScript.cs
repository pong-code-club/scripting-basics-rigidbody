using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    public Vector3 MyJumpForce;
    public ForceMode MyForceMode;
    public Vector3 MyGravityForce;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = MyGravityForce;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody.AddForce(MyJumpForce, MyForceMode);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
    }
}

//Common components
//Transform
//MeshFilter
//MeshRenderer
//Rigidbody

//life cycle events
//Start()
//Update()
//OnTriggerEnter()
//OnCollisionEnter()

//static vs instance variables/functions
//MonoBehaviour <- Behaviour <- Component <- Object
//Variables
//Functions
//GetComponent() - 
//Instantiate() - static function in Object class
//Destroy() - static function in Object class
//Loops
//If/Else
//Input Class
//Vector3 Class

//Useful Classes
//====================
//Transform
//Rigidbody
//SceneManager
//Physics
//Time

//Pong Classes
//====================
//Transform
//Rigidbody
//Communication between scripts
//TextMeshPro
//Casting
//Input class
//If statements
//Time class

//Physics Jump
//====================
//Functions
//Variables
//Input class
//Rigidbody class
//If statements
//Debug class
//Vector3 class
//ForceMode enum



