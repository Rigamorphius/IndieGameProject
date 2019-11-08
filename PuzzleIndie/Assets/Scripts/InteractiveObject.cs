using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);

public virtual string DisplayText => displayText;
    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    

    public virtual void InteractWith()
    {
        try
        {
            audioSource.Play();
     Debug.Log($"Player just interacted with: { gameObject.name}.");
        }
        catch (System.Exception)
        {
            throw new System.Exception("Missing audio source component or audio clip: Interactive object requires audio source component with an audio clip assigned");
        }
    }
} 
