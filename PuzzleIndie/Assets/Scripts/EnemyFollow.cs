using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<EnemyFollow>().enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        OnMouseOver();
        this.gameObject.GetComponent<NavMeshAgent>().destination = player.transform.position;
    }
    void OnMouseOver()
    {
        this.GetComponent<EnemyFollow>().enabled = true;
        Debug.Log("The player is looking at " + transform.name);
    }

}
