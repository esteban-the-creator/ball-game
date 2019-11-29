using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Health : MonoBehaviour
{

    int health = 3;
    public List<GameObject> pSalud = new List<GameObject>();
    private Transform playerPos;
    public Transform respawnPoint;
    public AudioClip impact;
    AudioSource audioSource;


    private void Start()
    {
        playerPos = this.transform;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //if (health == 2)
        //{
        //    pSalud[1] = gameObject.GetComponent<Renderer>().material.SetColor.red
        //}
        if(health <= 0)
        {
            Dead();
            health = 3;
        }
    }

    public void Dead()
    {
        playerPos.position = respawnPoint.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.transform.CompareTag("Spike")))
        {
            audioSource.PlayOneShot(impact, 0.7F);

            Handheld.Vibrate();

            health -= 1;

            print("saludmenios1");
        }
    }
}
