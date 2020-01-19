using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nivel_pausa : MonoBehaviour
{
    public static bool esta_pausado = false;

    public GameObject pausa_ui;
    public GameObject audio_ui;

    private GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador != null)
        {
            if (
            Input.GetKeyDown(KeyCode.Escape) ||
            Input.GetKeyDown(KeyCode.Space) ||
            Input.GetKeyDown(KeyCode.P)
            )
            {
                if (esta_pausado)
                {
                    Resumir();
                }
                else
                {
                    Pausar();
                }
            }
        }
    }

    void Resumir()
    {
        AudioSource musica = audio_ui.GetComponent<AudioSource>();
        musica.volume = 0.5f;

        pausa_ui.SetActive(false);
        esta_pausado = false;
        Time.timeScale = 1f;
    }

    void Pausar()
    {
        Time.timeScale = 0f;
        esta_pausado = true;
        pausa_ui.SetActive(true);

        AudioSource musica = audio_ui.GetComponent<AudioSource>();
        musica.volume = 0.2f;
    }
}
