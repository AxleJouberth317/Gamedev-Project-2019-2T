﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaculos_patron;

    private float tiempo_spawn;

    //public float tiempo_start = 1.25f;
    //public float tiempo_decrease = 0.05f;
    //public float tiempo_minimo = 0.65f;

    public float tiempo_start = 1f;
    public float tiempo_decrease = 0.00f;
    public float tiempo_minimo = 1f;

    public int nivel = 0;

    public Text porcentaje_txt;

    private int contador = 0;
    private float porcentaje = 0f;

    private int total = 100;

    private GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        if(nivel == 1)
        {
            total = 50;
        }
        else
        {
            total = 50;
        }

        porcentaje = (float) contador / (float) total * 100f;
        porcentaje = Mathf.RoundToInt(porcentaje);

        if(porcentaje >= 100)
        {
            porcentaje = 100;
        }

        porcentaje_txt.text = porcentaje.ToString() + "%";

        if (porcentaje >= 100)
        {
            if(nivel == 1)
            {
                SceneManager.LoadScene("nivel_02");
            }
            else
            {
                SceneManager.LoadScene("juego_creditos");
            }
        }

        if (tiempo_spawn <= 0)
        {
            int rand;
            if (jugador != null)
            {
                contador++;
            }

            if(contador == 1)
            {
                if(nivel == 2)
                {
                    rand = 1;
                }
                else
                {
                    rand = 1;
                }
            }
            else if(contador == 2)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, 2);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = 1;
                }
            }
            else if (contador == 3)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, 2);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = 1;
                }
            }
            else if (contador == 4)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, obstaculos_patron.Length);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = Random.Range(32, 35);
                    Debug.Log("r" + rand);
                }
            }
            else
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, obstaculos_patron.Length);
                    Debug.Log("r" + rand);
                }
                else
                {
                    //rand = Random.Range(2, obstaculos_patron.Length-4);
                    rand = Random.Range(2, 31);
                    Debug.Log("r" + rand);
                }
            }
            Instantiate(obstaculos_patron[rand], transform.position, Quaternion.identity);
            tiempo_spawn = tiempo_start;
            if (tiempo_start > tiempo_minimo)
            {
                tiempo_start -= tiempo_decrease;
            }
        }
        else
        {
            tiempo_spawn -= Time.deltaTime;
        }
    }
}
