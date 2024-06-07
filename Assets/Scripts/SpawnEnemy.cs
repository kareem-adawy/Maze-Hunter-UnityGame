using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    
    [SerializeField]
    private GameObject Enemyfab;
    [SerializeField]
    private Transform[] Places;

    public Text text;

    static public int Killednum;

    private GameObject player;

    public GameObject CounterObj;

    // Start is called before the first frame update
    void Start()
    {
        Killednum = 0;
        player = GameObject.FindGameObjectWithTag("Player");
        CounterObj = GameObject.FindGameObjectWithTag("freeze");


          CounterObj.GetComponent<Text>().enabled = false;


    }

    //IN CASE YOU'RE SUPER DOPER BORED AND YOU WANT TO PLAY FOREVER
    public void Spwannow()
       {
            Instantiate(
                Enemyfab, Places[Random.Range(0, 5)].position, Quaternion.identity);

        text.text = "Enemy Killed: " + ++Killednum ;
        player.GetComponent<PlayerHealth>().HealthUp();
        CounterObj.GetComponent<Text>().enabled = false;


    }
    
}
