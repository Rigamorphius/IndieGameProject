using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    private AudioSource audioSource;
    GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        
    }

    void Update()
    {   
        this.gameObject.GetComponent<NavMeshAgent>().destination = player.transform.position;

    }

    //private void OnMouseEnter()
    //{
    //    this.GetComponent<EnemyFollow>().enabled = true;
    //    audioSource.Stop();
    //}
}