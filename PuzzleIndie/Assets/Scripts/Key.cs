using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static int keyCount;
    GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key = GameObject.FindGameObjectWithTag("key");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            keyCount = 2;
            Destroy(key);
        }
    }
}
