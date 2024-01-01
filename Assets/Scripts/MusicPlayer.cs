using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Awake() 
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        
        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Destroy Audio Manager object when scene switched to Main Menu.
    public void DestroyMusicForMainMenu()
    {
        Destroy(gameObject);
    }
}
