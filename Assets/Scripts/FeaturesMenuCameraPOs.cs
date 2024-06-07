using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesMenuCameraPOs : MonoBehaviour
{
    GameObject maincamera;
    Transform temp;
    public GameObject FeaturesMenuCamera;
    public GameObject DeathCamera;


    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        FeaturesMenuCamera.transform.position = maincamera.transform.position;
        FeaturesMenuCamera.transform.rotation = maincamera.transform.rotation;

        DeathCamera.transform.position = maincamera.transform.position;
        DeathCamera.transform.rotation = maincamera.transform.rotation;
    }


}
