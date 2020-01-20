using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_over : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (
            Input.GetKeyDown(KeyCode.Backspace) ||
            Input.GetKeyDown(KeyCode.R)
            )
        {
            Debug.Log("GameOver/Reiniciar");
            Reiniciar();
        }
        else if (
            Input.GetKeyDown(KeyCode.Escape) ||
            Input.GetKeyDown(KeyCode.S)
            )
        {
            Debug.Log("GameOver/Salir");
            Salir();
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        SceneManager.LoadScene("juego_menu");
    }
}
