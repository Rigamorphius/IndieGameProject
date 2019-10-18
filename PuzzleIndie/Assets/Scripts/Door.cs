using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    [SerializeField]
    public bool isLocked = true;

    [SerializeField]
    private string lockedDisplayText = "Locked";

    [SerializeField]
    private AudioClip lockedAudioClip;

    [SerializeField]
    private AudioClip openAudioClip;

    public override string DisplayText => isLocked ? lockedDisplayText : base.displayText;

    private Animator animator;
    private bool isOpen = false;

    /// <summary>
    /// Using a Constructor here to initialize display text in the editor.
    /// </summary>
    public Door() {
        displayText = nameof(Door);
}
    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }
   
    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (!isLocked)
            {
                audioSource.clip = openAudioClip;
                animator.SetBool("shouldOpen", true);
                displayText = string.Empty;
                isOpen = true;
            }
            else {
                audioSource.clip = lockedAudioClip;
            }
        base.InteractWith();// This plays a sound effect
        }    
    }
}
