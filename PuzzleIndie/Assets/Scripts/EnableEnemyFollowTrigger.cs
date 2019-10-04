using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyFollowTrigger : MonoBehaviour
{
    [SerializeField]
    private EnemyFollow componentToEnable;
    private AudioSource audioSource;
    private AudioSource audioSource2;
    bool used = true;

    private void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        audioSource2 = GameObject.FindGameObjectWithTag("Sound2").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        componentToEnable.enabled = true;
        audioSource.Stop();
        if (used == true)
        {
            audioSource2.Play();
            used = false;
        }
    }
}
