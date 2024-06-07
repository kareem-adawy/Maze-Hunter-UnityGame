using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureMenuParent : MonoBehaviour
{

    private GameObject PlayerControls;
    private GameObject GunControls;
    public GameObject FeaturesMenuCamera;


    // Start is called before the first frame update
    void Start()
    {

        PlayerControls = GameObject.FindGameObjectWithTag("Player");
        GunControls = GameObject.FindGameObjectWithTag("Weapon");

        
    }

    // Update is called once per frame
    void Update()
    {
         if (gameObject.activeInHierarchy)
         {
             PlayerControls = GameObject.FindGameObjectWithTag("Player");
            GunControls = GameObject.FindGameObjectWithTag("Weapon");
             Invoke("WhenActive", 0f);
         }
  
    }

    void WhenActive()
    {
        
            Cursor.lockState = CursorLockMode.None;

            PlayerControls.SetActive(false);
            GunControls.SetActive(false);
            FeaturesMenuCamera.SetActive(true);
        
    }
}
