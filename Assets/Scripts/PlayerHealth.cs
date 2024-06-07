using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float MaxHealth;
    private float currentHealth;
    private float hurtPoints;
    private int killScore;

    public GameObject DeathCamera;

    private Vector3 temp;


    public GameObject PlayerControls;
    private GameObject GunControls;

    [SerializeField]
    private GameObject DeathScene;
    private GameObject playerObj;

    public Text text;

    public static bool shieldMood = false;

    public AudioSource soundTrack;

    

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100f;
        currentHealth = MaxHealth;
        hurtPoints = 5;

        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        text.text = "Player health: " + currentHealth;

        killScore = SpawnEnemy.Killednum;

        IncreaseDifficulty();

        Cursor.lockState = CursorLockMode.Locked;


    }

    private void IncreaseDifficulty()
    {
        switch (killScore)
        {
            case 5:
                hurtPoints = 10;
                break;
            case 8:
                hurtPoints = 15;
                break;
            case 13:
                hurtPoints = 20;
                break;
            
        }
                if(killScore > 20)
                {
                    hurtPoints = killScore * 2.5f;
                }
    }

    public void PlayerHurt()
    {
        if (!shieldMood)
        {
            currentHealth = currentHealth - hurtPoints;

            if (currentHealth <= 0)
            {
                GameOver();

            }
        }
    }

    public void HealthUp()
    {
        currentHealth = currentHealth + 20f;
    }

    private void GameOver()
    {
        
        DeathCamera.SetActive(true);

        soundTrack.enabled = false;
        

        GunControls = GameObject.FindGameObjectWithTag("Weapon");

        GunControls.SetActive(false);
        playerObj.SetActive(false);

        DeathScene.SetActive(true);

        Invoke("ReloadSence", 3);
    }

    private void ReloadSence()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}


