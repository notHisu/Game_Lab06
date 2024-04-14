using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
    private Button[] buttons;

    public bool isPaused = false;

    void Awake()
    {
        // Get the buttons
        buttons = GetComponentsInChildren<Button>();

        // Disable them
        HideButtons();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
                HideButtons();
            }
            else
            {
                PauseGame();
                ShowButtons();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;  // Pause the game by setting timescale to 0
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;  // Resume the game by setting timescale to 1
        isPaused = false;

    }

    public void HideButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void ShowButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ExitToMenu()
    {
        // Reload the level
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        // Reload the level
        SceneManager.LoadScene("Stage1");

    }
}