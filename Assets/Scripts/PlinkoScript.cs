using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoScript : MonoBehaviour
{
    public Vector3 GravityForce;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = GravityForce;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
