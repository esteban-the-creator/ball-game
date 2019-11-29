using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    int health = 3;

    public Transform respawnPoint;


   


    private void OnCollisionEnter2D(Collision2D collision) /* una funcion reservada que se ejecuta sola sin la necesidad de ser llamada en un Update que permite
       detectar cuándo se colisiona contra un objeto */
    {
        if ((collision.transform.CompareTag("LeftWall")) || (collision.transform.CompareTag("RigthWall")))
        {
            health -= 1;
            print("saludmenios1");
        }
        // la variable moveX sera igual a el valor que tenga moveX en ese momento por -1 para cambiar la magnitud de su direccion 

    
    }
}
