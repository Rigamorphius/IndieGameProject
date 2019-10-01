using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlip : MonoBehaviour
{

    GameObject walaCam;
    // Start is called before the first frame update
    void Start()
    {
        walaCam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
         transform.Rotate(new Vector​3(0.0f, 180.0f, 0.0f));
        }
    }
}
