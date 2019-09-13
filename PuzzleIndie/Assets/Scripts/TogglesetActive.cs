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

        if (gameObject.name == "Greed")
        {
            score = score += 1;
            Debug.Log(score.ToString());
           
        }
        else if (gameObject.name == "Wrath")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }
        else if (gameObject.name == "Pride")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }
        else if (gameObject.name == "Gluttony")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }
        else if (gameObject.name == "Sloth")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }
        else if (gameObject.name == "Envy")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }
        else if (gameObject.name == "Lust")
        {
            score = score += 1;
            Debug.Log(score.ToString());
        }

        if (score == 7) {
            SceneManager.LoadScene("Win");
        }

        if (isReusable || hasBeenUsed) {
        base.InteractWith();
            objectToggle.SetActive(!objectToggle.activeSelf);      
            hasBeenUsed = true;
            if (!isReusable) { displayText = string.Empty; }
        }
    }
}
