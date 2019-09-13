using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    public string gameSceneName;

    public void LoadGameScene() {
        SceneManager.LoadScene(gameSceneName);
    }

    public void ExitGame() {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
