using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
   
    public static bool PausedGame = false;

    public GameObject PauseMenuUI;
    public GameObject PlayerUI;
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedGame)
            {
                Resume();
            }
            else
            {
                Pause();
                SceneManager.LoadScene("Main Menu");
            }
            
        }
    }

    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
        Player.SetActive(true);
        PlayerUI.SetActive(true);
    }

    void Pause ()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
        Player.SetActive(false);
        PlayerUI.SetActive(false);
       
    }





}
