using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    
    private Transform player;
    private Rigidbody rb;
    private Animator anim;
    private NavMeshAgent nav;

    RaycastHit hit;
    public bool EnDead, onfreeze;

    public AudioSource source;
    public AudioSource killed;
    public AudioClip DieSound;

    public GameObject fire;
    public GameObject FreezeEffect;
    public GameObject FreezeEffectAfter;
    public Transform camerapos;

    public float health = 100f;
    public float max = 1f;

    private float freezeTime = 20f;

    private GameObject spawn;

    

    // Start is called before the first frame update
    void Start()
    {
        max = 1f;
       
     
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();

        EnDead = false;
        onfreeze = false;

        spawn = GameObject.FindGameObjectWithTag("Spwan");

   
    }

    // Update is called once per frame
    void Update()
    {

        max = max + Time.deltaTime;
        if (!EnDead && !onfreeze)
        {
            
        
            shoot();

        }

        if (onfreeze)
        {
            if (freezeTime > 0)
            {
                freezeTime -= Time.deltaTime;
            }
            else
            {
                UNfreeze();
            }
        }


    }

    private void Animate()
    {
       if(Vector3.Distance(transform.position, player.transform.position) >= 1.5f)
        {
            nav.enabled = true;
            nav.SetDestination(player.position);

        } else
        {
            nav.enabled = false;
        }
        
            if (nav.remainingDistance <= nav.stoppingDistance)
            {
                anim.SetBool("Run", false);

            }
            else
            {
                anim.SetBool("Run", true);

            }
        
    }

    void shoot()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.transform.tag == "Player" && max >= 0.09f && !EnDead)
            {
                max = 0;
                anim.SetTrigger("Shoot");

                source.Play();
                Instantiate(fire, hit.point + new Vector3 (0f, 0.8f,0f), Quaternion.LookRotation(hit.normal));
                player.GetComponent<PlayerHealth>().PlayerHurt();

                

            } else
            {
                Animate();
            }
        }
    }

   public void Die()
    {
        anim.enabled = true;
        anim.SetTrigger("Hurt");
        health -= 10f;

        if (health == 0)
        {
            finalDie();
        }

        }

    public void finalDie()
    {
        source.PlayOneShot(DieSound);
        anim.SetBool("Die", true);
       nav.enabled = false;
        EnDead = true;
        Destroy(gameObject, 1.5f);
        spawn.GetComponent<SpawnEnemy>().Spwannow();
    }

    public void freeze()
    {
        onfreeze = true;
        Instantiate(FreezeEffect, transform);
        Debug.Log("freeze");
       nav.enabled = false;
        anim.enabled = false;
        

    }

    public void UNfreeze()
    {
        FreezeEffectAfter = GameObject.FindGameObjectWithTag("FreezeEffect");
        Destroy(FreezeEffectAfter);
        onfreeze = false;
        Debug.Log(" Not frozen");
        nav.enabled = true;
        anim.enabled = true;
    }

    



 }  

