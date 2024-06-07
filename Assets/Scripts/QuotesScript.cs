using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuotesScript : MonoBehaviour
{
    int numOfQuotes = 9;
    private Text text;
    private string[] QuotesList = {

        "\"War does not determine who is right, only who is left\" -Burtrand Russell",
        "\"I'm tired of putting quotes, You need to stop dying my man!\" ",
        "\"If the enemy is in range, so are you.\" -Infantry Journal",
        "\"Knowing how to fight alone is the most essenial skill for survival\" -A wise guy",
        "\"Everyone lives alone in his goddamned universe\" - Uncle Junior Soprano",
        "\"And where are your so called firends now? you're all alone\"- Reminder form The creator of the Game" ,
        "\"No one will save you. People are basically busy living their lives.\" -Avijeet Das",
        "“You're old enough now to learn the most important lesson in life: You cannot count on anyone except yourself.” —Carolyn in American Beauty.",
        "\"I award you no points, and may God have mercy on your soul.\" -Billy Madison, 1995",
    }; 
        









    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = QuotesList[Random.Range(0, numOfQuotes)];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
