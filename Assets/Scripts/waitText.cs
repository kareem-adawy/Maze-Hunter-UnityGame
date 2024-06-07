using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitText : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public float i = 6f;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Counter();

    }

    void Counter ()
    {
        if( i > 0)
        {
        i -= Time.unscaledDeltaTime;
        text.text = "GAME STARTS IN: \n" + Mathf.RoundToInt(i);
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}
