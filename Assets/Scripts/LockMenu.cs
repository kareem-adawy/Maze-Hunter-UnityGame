using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockMenu : MonoBehaviour
{
    public GameObject ShieldLock;
    public GameObject SpyLock;
    public GameObject FreezeLock;
    public GameObject InstantLock;

    public GameObject Bagde1;
    public GameObject Bagde5;
    public GameObject Bagde10;
    public GameObject Bagde50;

    public Button ShieldButton;
    public Button SpyButton;
    public Button FreezeButton;
    public Button InstantButton;

    int score; 


    public GameObject firstMystereyBox;





    // Update is called once per frame
    void Update()
    {
        score  = SpawnEnemy.Killednum;

        if(score >= 1)
        {
            Bagde1.SetActive(true);
            ShieldButton.interactable = true;
            ShieldLock.SetActive(false);


            if(firstMystereyBox != null)
                firstMystereyBox.SetActive(true);
        }

        if (score >= 5)
        {
            Bagde5.SetActive(true);
            SpyButton.interactable = true;
            SpyLock.SetActive(false);

        }

        if (score >= 10)
        {
            Bagde10.SetActive(true);
            FreezeButton.interactable = true;
            FreezeLock.SetActive(false);

        }

        if (score >= 50)
        {
            Bagde50.SetActive(true);
            InstantButton.interactable = true;
            InstantLock.SetActive(false);

        }



    }
}
