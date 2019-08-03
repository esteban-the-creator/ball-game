using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float force = 5;
    Rigidbody2D PlayerRgdBdy;

    private void Start()
    {
        PlayerRgdBdy = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Movement();
        }
    }

    public void Movement()
    {
        PlayerRgdBdy.AddForce

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