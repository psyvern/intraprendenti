using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadNewScene()
    {
        // Carica la scena con il nome specificato
        SceneManager.LoadScene(1);
    }
    
    public void QuitGame()
    {
        // Esci dal gioco
        Application.Quit();
    }
    
}
