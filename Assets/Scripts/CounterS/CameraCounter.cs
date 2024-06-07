using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public float i = 15f;
    public GameObject SpyIcon;

    public GameObject CheatCamera;

    void Start()
    {
        text = GetComponent<Text>();
        i = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (text.enabled)
        {
            Counter();
        } else
        {
            i = 20f;
        }

    }

    void Counter ()
    {
        
        if ( i > 0)
        {
        i -= Time.deltaTime;
        text.text = "The Spy Camera Will Disapear After: \n" + Mathf.RoundToInt(i);

            SpyIcon.SetActive(true);
            if (i < 17)
            {
                text.text = "\n" + Mathf.RoundToInt(i);
                text.fontSize = 75;
                text.transform.position = SpyIcon.transform.position + new Vector3(0, 0, 0);
            }

        } else
        {

            text.enabled = false;
            SpyIcon.SetActive(false);
            CheatCamera.SetActive(false);
             i = 20f;
        }
    }
}
