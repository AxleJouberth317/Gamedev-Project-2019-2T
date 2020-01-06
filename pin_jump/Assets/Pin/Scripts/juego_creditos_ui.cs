using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class juego_creditos_ui : MonoBehaviour
{
    public void BotonIntro()
    {
        SceneManager.LoadScene("juego_menu");
    }
}
