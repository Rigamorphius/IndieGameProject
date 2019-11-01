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
        //audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        agent = gameObject.GetComponent<NavMeshAgent>();

        /* ckrueger audio*/
        PlayDemonRoar();
        PlayDemonBreathe();
    }

    void Update()
    {         
        agent.SetDestination(player.transform.position);
    }

    /* ckrueger audio vvv */
    private void PlayDemonBreathe()
    {
        AkSoundEngine.PostEvent("DemonBreathe", gameObject);
    }

    private void PlayDemonRoar()
    {
        AkSoundEngine.PostEvent("DemonRoar", gameObject);
    }
    /* ckrueger audio ^^^ */
}