using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    [SerializeField]
    private InventoryObject key;

    [SerializeField]
    private bool consumesKey;

    [SerializeField]
    private string lockedDisplayText = "Locked";

    /* ckrueger audio */
    //commented these out since theyre unneccessary after Wwise integration
    //[SerializeField]
    //private AudioClip lockedAudioClip;

    //[SerializeField]
    //private AudioClip openAudioClip;

    //public override string DisplayText => isLocked ? lockedDisplayText : base.displayText;

        public override string DisplayText {
        get {
            string toReturn;
            if (isLocked)
            {
                toReturn = HasKey ? $"Use {key.ObjectName}" : lockedDisplayText;
            }
            else {
                toReturn =  base.DisplayText;
            }
            return toReturn;
        }
    }

    public bool HasKey => PlayerInventory.InventoryObjects.Contains(key);
    private Animator animator;
    private bool isOpen = false;
    public bool isLocked;
   // private int shouldOpenAnimParameter = Animator.StringToHash(nameof(shouldOpenAnimParameter));
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
        InitializeIsLocked();
    }

    private void InitializeIsLocked()
    {
        if (key != null)
        {
            isLocked = true;
        }
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (isLocked && !HasKey)
            {
                /* ckrueger audio */
                PlaySoundDoorLocked();
            }
            else
            {
                //audioSource.clip = openAudioClip;

                animator.SetBool("shouldOpen", true);
                displayText = string.Empty;
                isOpen = true;
                UnlockDoor();
            }
            base.InteractWith();// This plays a sound effect
        }    
    }

    private void UnlockDoor()
    {
        isLocked = false;
        if (key != null && consumesKey)
        {
            PlayerInventory.InventoryObjects.Remove(key);
        }
    }

    /* ckrueger audio */
    void PlaySoundDoorLocked()
    {
        AkSoundEngine.PostEvent("DoorLocked", gameObject);
    }
}
