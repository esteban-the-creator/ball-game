using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sphere : MonoBehaviour
{
    public float forceUP = 50;
    public float moveX = 2.5f;
    public float timer = 5f;
    private Rigidbody2D PlayerRgdBdy;
    public Transform halfSpace;
    public int score = 0;
    public Text puntaje;
    public Canvas pausa, winner;
    private bool pause ;
    public AudioClip Uwin;
    AudioSource audioSource;


    private void Awake()
    {
        winner.enabled = false;
    }
    private void Start()
    {
        Stop();
        audioSource = GetComponent<AudioSource>();
        PlayerRgdBdy = GetComponent<Rigidbody2D>(); // a la variable rigidbody creada se le asigna el componente RigidBody2D del objeto al que se le asigne
    }

    private void Update()
    {
        puntaje.text = score.ToString();

        if (pause == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Begin();
            }

        }

        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Movement();


            }
        }

        if (score == 10  || score > 10 )
        {
            Win();

            timer -= 1 * Time.deltaTime;

            print("timne:" + timer);

            if (timer <= 0)
            {
                winner.enabled = false;
            }
        }
    }

    public void Win()
    {
        winner.enabled = true;
        audioSource.PlayOneShot(Uwin, 0.4F);
    }

    public void Begin()
    {
        Time.timeScale = 1;
        pausa.enabled = false;
        pause = false;
    }

    public void Stop()
    {
        pausa.enabled = true;
        pause = true;
        Time.timeScale = 0;
    }

    public void Movement()
    {
        PlayerRgdBdy.velocity = new Vector2(moveX, forceUP); // velocity es una propiedad de la clase Rigidbody que permite modificar la posicion del transform
    }

    private void OnCollisionEnter2D(Collision2D collision) /* una funcion reservada que se ejecuta sola sin la necesidad de ser llamada en un Update que permite
       detectar cuándo se colisiona contra un objeto */
    {
        if ((moveX > 0 && collision.transform.CompareTag("LeftWall")) || (moveX < 0 && collision.transform.CompareTag("RigthWall")))
        {
            moveX *= -1;
            print ("choque");
        }
         // la variable moveX sera igual a el valor que tenga moveX en ese momento por -1 para cambiar la magnitud de su direccion 

        if (collision.transform.tag == "LeftWall" || collision.transform.tag == "RigthWall")
        {
            score += 1;
            if (transform.position.y >= halfSpace.transform.position.y)
            {
                PlayerRgdBdy.velocity = new Vector2(moveX, -30);
            }
        }

        if (collision.transform.tag == "LeftWall")
        
        {
            collision.transform.GetComponent<Spikes>().EnableSpikes(); // se llama a la funcion de activar chuzos que maneja el script que tiene la pared

            GameObject.FindWithTag("RigthWall").transform.GetComponent<Spikes>().HideSpikes();//se busca a los gameobjects de tag pared derecha (osea contraria) y se llama a la funcion esconderlos
        }

        if (collision.transform.tag == "RigthWall")

        {
            collision.transform.GetComponent<Spikes>().EnableSpikes();

            GameObject.FindWithTag("LeftWall").transform.GetComponent<Spikes>().HideSpikes();
        }
    }  


}

/*
  
 * rigibdoy.velocity y .addforce
 * use movetowards
 

 que los chuzos hagan que se pierda
 que haya algun elemento que se deba coger como puntos
 que aparecan chuzos laterales aleatorios en posiciones diferentes a las de los puntos que se deben coger 

     */