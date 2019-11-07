using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private AudioSource audioSource;
    private NavMeshAgent agent;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        agent = gameObject.GetComponent<NavMeshAgent>();

        /* ckrueger audio */
        PlaySoundDemonMovement();
    }

    void Update()
    {         
        agent.SetDestination(player.transform.position);
    }

    /* ckrueger audio */
    void PlaySoundDemonMovement()
    {
        AkSoundEngine.PostEvent("DemonFloat", gameObject);
    }
}