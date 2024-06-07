using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
   // [SerializeField]
    //private GameObject FeaureSystemMenu;

    private temp temp;
    public GameObject FeaureSystemMenu;
    private GameObject spawn;



    // Start is called before the first frame update
    void Awake()
    {


        spawn = GameObject.FindGameObjectWithTag("Spwan");

    }

    private void Start()
    {
        temp = GameObject.FindGameObjectWithTag("temp").GetComponent<temp>();
        FeaureSystemMenu = temp.tempParent;


       // FeaureSystemMenu = GameObject.FindGameObjectWithTag("FeaureMenuParent");
        //temp = FeaureSystemMenu;
        //FeaureSystemMenu.SetActive(false);

        


        //FeaureSystemMenu = GameObject.FindGameObjectWithTag("FeaureMenuParent");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("Ice Broke");
           FeaureSystemMenu.SetActive(true);
            spawn.GetComponent<SpawnObject>().Spwannow();
            Destroy(gameObject);

        }

    }
}
