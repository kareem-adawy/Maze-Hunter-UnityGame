using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freeze : MonoBehaviour
{
    private Enemy EnemyObJ;
    private GameObject CounterObj;
    private GameObject spawn;

    private void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Spwan");
        CounterObj = GameObject.FindGameObjectWithTag("freeze");

    }

  /*  private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {
            EnemyObJ = GameObject.FindGameObjectWithTag("Dummie").GetComponent<Enemy>();
        freezeEnemy();
       

            Destroy(gameObject);

        } 

    }

    */


     private void freezeEnemy()
    {
        EnemyObJ.freeze();

        CounterObj.GetComponent<Text>().enabled = true;
        //spawn.GetComponent<SpawnObject>().Spwannow();
    }

    
}
