using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }    
public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
public void Exit()
    {
        Application.Quit();
    }
public void LoadSettingsScene()
    {
        SceneManager.LoadScene(2);
        ResumeGame();
    }

private void ResumeGame() { Time.timeScale = 1; }

}