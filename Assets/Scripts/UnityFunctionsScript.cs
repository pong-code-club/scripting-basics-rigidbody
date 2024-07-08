using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//static vs member
//declare function
//call function

public class UnityFunctionsScript : MonoBehaviour
{
    public GameObject OtherGO;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Plane");
        Destroy(null);
        GetComponent<Transform>();
        Instantiate(GameObject.Find("Plane"));
        Input.GetKey(KeyCode.Escape);
        //SceneManager.LoadScene("");
        transform.position = Vector3.zero;

        gameObject.name = "hello";
        OtherGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            OtherGO.SetActive(true);
        }
    }

    public void TestFunction()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 0), ForceMode.Impulse);
        GetComponent<Transform>().position = new Vector3(0, 0, 0);
        Input.GetKeyDown(KeyCode.Space);
        GetComponent<GameObject>().name = "hello";
    }
}
