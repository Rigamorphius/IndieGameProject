using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyFollowTrigger : MonoBehaviour
{
    [SerializeField]
    public EnemyFollow componentToEnable;

    private AudioSource audioSource;
    private AudioSource audioSource2;
    bool used = true;

    private void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        audioSource2 = GameObject.FindGameObjectWithTag("Sound2").GetComponent<AudioSource>();
        componentToEnable.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (used == true)
        {      componentToEnable.enabled = true;
            audioSource.Stop();
            audioSource2.Play();
            used = false;
        }
    }
}
