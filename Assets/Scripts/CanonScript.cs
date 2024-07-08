using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CanonScript : MonoBehaviour
{
    public Vector3 MyCanonForce;
    public Rigidbody MyRigidbody;
    public ForceMode MyForceMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody.AddForce(MyCanonForce, MyForceMode);
        }
    }
}
