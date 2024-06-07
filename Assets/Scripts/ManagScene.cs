using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagScene : MonoBehaviour
{
    bool GamePaused = false;
    public GameObject PausePanel;

    private GameObject PlayerControls;
    private GameObject GunControls;
    public GameObject tempCamera;


    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;

        PlayerControls = GameObject.FindGameObjectWithTag("Player");

        Invoke("GunFind", 1f); // cuz the gun is a clone that gets instatiated ater the game starts


    }

    // Update is called once per frame
    void Update()
    {


        PauseGame();
/*
        if(GamePaused)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ResumeGame();
            }
        }
*/
    }

    void PauseGame()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.None;


            Time.timeScale = 0;
            PausePanel.SetActive(true);
            tempCamera.SetActive(true);
            GamePaused = true;

            PlayerControls.SetActive(false);
            GunControls.SetActive(false);


        }
    }

   public void ResumeGame()
    {
    
         Time.timeScale = 1;
        PausePanel.SetActive(false);
        tempCamera.SetActive(false);
        GamePaused = false;

        PlayerControls.SetActive(true);
        GunControls.SetActive(true);

    }

   public void RestartMission()
    {
        SceneManager.LoadScene(1);
    }

   public void Quit()
    {
        Application.Quit();
    }

    public void GunFind()
    {
        GunControls = GameObject.FindGameObjectWithTag("Weapon");

    }
}
