using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuControl : MonoBehaviour
{
    public GameObject pausePanel;

    public void PauseButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1.0f;
        CamControl.goldCount = 0;
        CamControl.score = 0;
    }

     public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
        CamControl.goldCount = 0;
        CamControl.score = 0;
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
    }

    public void TryAgainButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void UpgaradeMenu()
    {
        SceneManager.LoadScene("UpgradeScene");
    }
}
