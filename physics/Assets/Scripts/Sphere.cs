using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float forceUP = 5;
    public float moveX = 2.5f;
    Rigidbody2D PlayerRgdBdy;

    private void Start()
    {
        PlayerRgdBdy = GetComponent<Rigidbody2D>();
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
        PlayerRgdBdy.velocity = new Vector2(moveX, forceUP);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveX *= -1;
    }


}

/*
 * 
 * rigibdoy.velocity y .addforce
 * use movetowards
 que una gravedad lo tire al piso 
 que al ar click salte en parabola contra la direccion de la gravedad
 que los chuzos hagan que se pierda
 que haya algun elemento que se deba coger como puntos
 que aparecan chuzos laterales aleatorios en posiciones diferentes a las de los puntos que se deben coger 

     */