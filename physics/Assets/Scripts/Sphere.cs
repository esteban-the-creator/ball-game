using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float forceUP = 50;
    public float moveX = 2.5f;
    private Rigidbody2D PlayerRgdBdy;
    public Transform halfSpace;

    private void Start()
    {
        PlayerRgdBdy = GetComponent<Rigidbody2D>(); // a la variable rigidbody creada se le asigna el componente RigidBody2D del objeto al que se le asigne
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Movement();
        }
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