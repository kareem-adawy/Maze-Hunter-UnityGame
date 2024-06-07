using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Transform[] Places;

    [SerializeField]
    private int spwanDelay = 55;







    // Start is called before the first frame update
    void Awake()
    {
        

    }


    //IN CASE YOU'RE SUPER DOPER BORED AND YOU WANT TO PLAY FOREVER
    public void Spwannow()
       {

        Invoke("DelaySpwan", spwanDelay);


        }

    void DelaySpwan()
    {
        Instantiate(
                prefab, Places[Random.Range(0, 5)].position, Quaternion.identity);
        Debug.Log("Spwan ICE");
    }


}
