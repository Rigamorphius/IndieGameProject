using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckForPlayerMovement();
    }

    void CheckForPlayerMovement()
    {
        //if (something!! idk!!!)
        {
            InvokeRepeating("PlayFootstep", 0f, 0.40f);
        }
    }

    void PlayFootstep()
    {
        AkSoundEngine.PostEvent("PlayerFootstep", gameObject);
    }
}
