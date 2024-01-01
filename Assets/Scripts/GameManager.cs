using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Return to main menu
    public void MainMenuScene()
    {
        FindObjectOfType<MusicPlayer>().DestroyMusicForMainMenu();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
