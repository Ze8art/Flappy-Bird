using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject[] startGameUIComponents;
    GameObject[] gameOverUIComponents;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponents(gameOverUIComponents);
        EnableUIComponents(startGameUIComponents);
        DisableScore(score);
    }

    public void DisableStartUI()
    {
        DisableUIComponents(startGameUIComponents);
    }

    public void gameOver()
    {
        EnableUIComponents(gameOverUIComponents);
        Time.timeScale = 0;
    }

    private void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }

    public void ShowScore()
    {
        score.SetActive(true);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableUIComponents(GameObject[] startGameUIComponents)
    {
        foreach (GameObject obj in startGameUIComponents)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponents(GameObject[] gameOverUIComponents)
    {
        foreach(GameObject obj in gameOverUIComponents)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
