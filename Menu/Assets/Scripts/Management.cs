using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management : MonoBehaviour
{
    public static Management Instance;

    /*
    public delegate void Delegate();
    public static event Delegate OnGameStart;
    public static event Delegate OnGameOver;
    */

    public GameObject menuPage;
    public GameObject startPage;
    public GameObject gameOverPage;

    //public Text scoreText;

    enum PageState { 
        None,
        Menu,
        Start,
        GameOver,
    }


    bool gameOver = false;
    public bool GameOver { get { return gameOver; } }

    void Awake()
    {
        Instance = this;
    }

    void SetPageState(PageState state)
    {
        switch (state)
        {
            case PageState.None:
                startPage.SetActive(false);
                menuPage.SetActive(false);
                gameOverPage.SetActive(false);
                break;
            case PageState.Menu:
                startPage.SetActive(false);
                menuPage.SetActive(true);
                gameOverPage.SetActive(false);
                break;
            case PageState.Start:
                startPage.SetActive(true);
                menuPage.SetActive(false);
                gameOverPage.SetActive(false);
                break;
            case PageState.GameOver:
                startPage.SetActive(false);
                menuPage.SetActive(false);
                gameOverPage.SetActive(true);
                break;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
