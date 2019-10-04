using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
            Destroy(this.gameObject);
    }
}
