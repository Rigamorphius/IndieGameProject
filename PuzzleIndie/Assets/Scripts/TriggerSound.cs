using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerSound : MonoBehaviour
{

    private AudioSource audioSource;
    bool used = true;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (used == true) {
audioSource.Play();
        Debug.Log("Sound Played");
            used = false;
        }

        
        
    }
}
