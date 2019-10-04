using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DoorLock : InteractiveObject
{
    [SerializeField]
    public bool isLocked = true;

    [SerializeField]
    private string lockedDisplayText = "Locked";

    public override string DisplayText => isLocked ? lockedDisplayText : base.displayText;

    private Animator animator;
    private bool isOpen = false;

    /// <summary>
    /// Using a Constructor here to initialize display text in the editor.
    /// </summary>
    public DoorLock()
    {
        displayText = nameof(Door);
    }
    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        if (!isOpen && Key.keyCount > 0)
        {
            base.InteractWith();
            animator.SetBool("shouldOpen", true);
            displayText = string.Empty;
            isOpen = true;
        }
    }
}
