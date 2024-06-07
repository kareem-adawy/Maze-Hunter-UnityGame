using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public float i = 20f;
    public GameObject freezeIcon;

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
            freezeIcon.SetActive(false);

        }

    }

    void Counter ()
    {
        
        if ( i > 0)
        {
        i -= Time.deltaTime;
        text.text = "The Enemy Will Be Unfrozen After: \n" + Mathf.RoundToInt(i);
            freezeIcon.SetActive(true);

            if (i < 17)
            {
                text.text = "\n" + Mathf.RoundToInt(i);
                text.fontSize = 75;
                text.transform.position = freezeIcon.transform.position + new Vector3(0, 15, 0);
            }

        } else
        {

            text.enabled = false;
            freezeIcon.SetActive(false);

            i = 20f;
        }
    }
}
