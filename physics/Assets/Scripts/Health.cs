using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Health : MonoBehaviour
{

    int health = 3;
    public List<Renderer> pSalud = new List<Renderer>();
    private Transform playerPos;
    public Transform respawnPoint;
    public AudioClip impact, death;
    AudioSource audioSource;

 
    private void Start()
    {
        playerPos = this.transform;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (health <= 2)
        {
            pSalud[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (health <= 1)
        {
            pSalud[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (health <= 0)
        {
            audioSource.PlayOneShot(death, 0.4F);
            Dead();
            if (Input.GetMouseButtonDown(0))
            {
               Revive();
            }
        }
    }

    public void Dead()
    {
        playerPos.position = respawnPoint.position;
        gameObject.GetComponent<Sphere>().Stop();
        gameObject.GetComponent<Sphere>().timer = 5;


    }

    public void Revive()
    {
        health = 3;
        pSalud.ForEach((sphere) => sphere.GetComponent<SpriteRenderer>().color = Color.green);
        gameObject.GetComponent<Sphere>().score = 0;
        gameObject.GetComponent<Sphere>().Begin();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.transform.CompareTag("Spike")))
        {
            audioSource.PlayOneShot(impact, 0.7F);

            Handheld.Vibrate();

            health -= 1;

            print("saludmenios1");

            gameObject.GetComponent<Sphere>().Movement();
        }

        if (collision.transform.tag == "Saw")

        {
            Handheld.Vibrate();
            health -= 3;
        }
    }
}
