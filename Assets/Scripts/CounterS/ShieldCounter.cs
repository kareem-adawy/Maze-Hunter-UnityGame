using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public float i = 15f;
    public GameObject ShieldEffect;
    public GameObject ShieldIcon;



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
            text.text = "The Shield Armor Will Disapear After: \n" + Mathf.RoundToInt(i);
            ShieldIcon.SetActive(true);
            if (i < 17)
            {
                text.text = "\n" + Mathf.RoundToInt(i);
                text.fontSize = 75;
                text.transform.position = ShieldIcon.transform.position + new Vector3(0,38,0);
            }

            PlayerHealth.shieldMood = true;

            ShieldEffect.SetActive(true);

            
            

        } else
        {

            text.enabled = false;
            PlayerHealth.shieldMood = false;

            ShieldEffect.SetActive(false);
            ShieldIcon.SetActive(false);



            i = 20f;
        }
    }
}
