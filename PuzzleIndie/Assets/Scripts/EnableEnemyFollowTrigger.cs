using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyFollowTrigger : MonoBehaviour
{
    [SerializeField]
    public EnemyFollow componentToEnable;

    //private AudioSource audioSource;
    //private AudioSource audioSource2;

    bool used = true;

    private void Start()
    {
        /* ckrueger audio */
        //commented these out since I do not use them

        //audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
        //audioSource2 = GameObject.FindGameObjectWithTag("Sound2").GetComponent<AudioSource>();

        componentToEnable.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (used == true)
        {      componentToEnable.enabled = true;

            /* ckrueger audio*/
            PlayDemonAttack();

            used = false;
        }
    }

    /* ckrueger audio vvv */
    private void PlayDemonAttack()
    {
        AkSoundEngine.PostEvent("Demon_Attack", gameObject);
    }
    /* ckrueger audio ^^^ */
}
