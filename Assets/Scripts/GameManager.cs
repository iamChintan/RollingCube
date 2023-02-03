using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool IsEnded = false;
    private int delayForRestart = 2;
    public GameObject levelComplete;

    public void LevelComplete()
    {
        levelComplete.SetActive(true);
    }

    public void EndGame()
    {
        if (!IsEnded)
        {
            Debug.Log("Game Over..!");
            IsEnded = true;
            Invoke("Restart", delayForRestart);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
