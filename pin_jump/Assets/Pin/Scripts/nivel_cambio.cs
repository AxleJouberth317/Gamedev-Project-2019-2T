﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel_cambio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Time.timeScale = 1f;
            Debug.Log("Cheat/Nivel 1");
            SceneManager.LoadScene("nivel_01");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Time.timeScale = 1f;
            Debug.Log("Cheat/Nivel 2");
            SceneManager.LoadScene("nivel_02");
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Time.timeScale = 1f;
            Debug.Log("Cheat/Menu");
            SceneManager.LoadScene("juego_menu");
        }
    }
}
