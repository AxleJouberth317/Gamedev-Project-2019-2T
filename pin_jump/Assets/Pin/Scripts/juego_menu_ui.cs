using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class juego_menu_ui : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene("nivel_01");
    }

    public void BotonCreditos()
    {
        SceneManager.LoadScene("juego_creditos");
    }

    public void BotonSalir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
