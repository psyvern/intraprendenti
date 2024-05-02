using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
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
        // Se ancora è in fase di testing:
        EditorApplication.isPlaying = false;
    }
    
}
