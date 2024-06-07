using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeaturesMenu : MonoBehaviour
{
    private GameObject PlayerControls;
    private GameObject GunControls;
    public GameObject FeaturesMenuCamera;
    public GameObject DeathCamera;


    public GameObject FeaturesMenuParent;

    private Enemy EnemyObJ;
    
    public GameObject CheatCamera;

    private GameObject freezeCounterObj;
    private GameObject CameraCounterOb;
    private GameObject ShieldCounterOb;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        GunControls = GameObject.FindGameObjectWithTag("Weapon");
        PlayerControls = GameObject.FindGameObjectWithTag("Player");
        
        FeaturesMenuCamera.SetActive(true);
        PlayerControls.SetActive(false);
        GunControls.SetActive(false);




        freezeCounterObj = GameObject.FindGameObjectWithTag("freeze");
        CameraCounterOb = GameObject.FindGameObjectWithTag("CameraCounter");
        ShieldCounterOb = GameObject.FindGameObjectWithTag("ShieldCounter");

    }

    // Update is called once per frame
    void Update()
    {
        


        PauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

   public void freezeButton()
    {
        EnemyObJ = GameObject.FindGameObjectWithTag("Dummie").GetComponent<Enemy>();
        freezeCounterObj.GetComponent<Text>().enabled = true;

        EnemyObJ.freeze();
        Debug.Log("Button working");

        ReturnGameToNormal();
    }

   
    public void SpyCameraButton()
    {
        CheatCamera.SetActive(true);
        CameraCounterOb.GetComponent<Text>().enabled = true;
        ReturnGameToNormal();
    }
    public void ShieldButton()
    {
        
        ShieldCounterOb.GetComponent<Text>().enabled = true;

        ReturnGameToNormal();
    }
    public void InstantDeathButton()
    {
        //PlayerControls.SetActive(false);
        //GunControls.SetActive(false);
      //  FeaturesMenuParent.SetActive(false);
        //FeaturesMenuCamera.SetActive(false);
        //ResumeGame();
        //DeathCamera.SetActive(true);

        EnemyObJ = GameObject.FindGameObjectWithTag("Dummie").GetComponent<Enemy>();
        EnemyObJ.finalDie();
        ReturnGameToNormal();

        Debug.Log("InstantDeath ON");
        //Invoke("ReturnGameToNormal", 2);
    }



    private void ReturnGameToNormal()
    {
        ResumeGame();


      
        FeaturesMenuParent.SetActive(false);
        FeaturesMenuCamera.SetActive(false);
        PlayerControls.SetActive(true);
        GunControls.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("Back to normal");


    }

    
}
