using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float forceUP = 5;
    public float moveX = 2.5f;
    private Rigidbody2D PlayerRgdBdy;

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
        moveX *= -1; // la variable moveX sera igual a el valor que tenga moveX en ese momento por -1 para cambiar la magnitud de su dirección
    }


}

/*
 * 
 * rigibdoy.velocity y .addforce
 * use movetowards
 que una gravedad lo tire al piso Y
 que al ar click salte en parabola contra la direccion de la gravedadY
 que los chuzos hagan que se pierda
 que haya algun elemento que se deba coger como puntos
 que aparecan chuzos laterales aleatorios en posiciones diferentes a las de los puntos que se deben coger 

     */