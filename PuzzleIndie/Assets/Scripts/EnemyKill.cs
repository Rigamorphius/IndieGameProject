using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        /* ckrueger audio */
        AkSoundEngine.PostEvent("Stop_All", gameObject);
        PlaySoundPlayerDie();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /* ckrueger audio */
    void PlaySoundPlayerDie()
    {
        AkSoundEngine.PostEvent("PlayerDie", gameObject);
    }
}
