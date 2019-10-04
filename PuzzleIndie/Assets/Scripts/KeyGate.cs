using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    GameObject door;

    void Start()
    {
        door = GameObject.FindGameObjectWithTag("door");
    }

    private void OnTriggerEnter(Collider other)
    {Debug.Log("Keycount = " + Key.keyCount);
        if (other.gameObject.tag == "Player" && Key.keyCount > 0)
        {

            Key.keyCount--;
            Destroy(door);
        }
    }

}
