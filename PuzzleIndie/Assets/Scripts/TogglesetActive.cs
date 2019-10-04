using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TogglesetActive : InteractiveObject
{
    private AudioSource audioSource;
    public static int score = 0;
    [Tooltip("The game object to toggle")]
    [SerializeField]
    private GameObject objectToggle;
    
    [Tooltip("Can the player interact with this more than once")]
    [SerializeField]
    private bool isReusable = true;
    private bool hasBeenUsed = false;
    
    void Start() {
audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Toggles the activeSelf value for the objectToggle when the player interacts with this item
    /// </summary>
    
    public override void InteractWith()
    {

        
        if (isReusable || hasBeenUsed) {
        base.InteractWith();
            objectToggle.SetActive(!objectToggle.activeSelf);      
            hasBeenUsed = true;
            if (!isReusable) { displayText = string.Empty; }
        }
    }
}
