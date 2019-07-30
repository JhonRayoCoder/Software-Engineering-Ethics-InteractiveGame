using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void cargarSiguiente()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void cargarInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void exit()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
    
}
