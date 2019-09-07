using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Vector2 start, end;
    private float offset = 2; // se debe declarar este offset privado,porque si se hace publico unity lo de un valor desde el principio en 0 independientemente de que esté declarado en 2
    Vector2 posToGo;

    public void InitializeAsLeft()
    {
        posToGo = start = new Vector2(transform.position.x, transform.position.y); // el transform.position es un vector3 por lo que debe ser casteado, como no permite hacer un casteo general para obtener las dos variables, se castea una a una

        end = (Vector2)transform.position + (Vector2.right * offset); /* al principio la expresión "(Vector2) transform.position"  esta haciendo un casting a vector2 del transform.position, que como se mencionó está en vector3
        y a ese tranform.position en vector2, se le suma un vector2.derecha(osea el eje x normalizado en 1) multiplicado por el valor de la variable offsetRigth (el resultado va a ser que el valor del eje x sera el del ofset rigth, es una multiplicacion por 1*/
    }

    public void InitializeAsRigth()
    {
        posToGo = start = new Vector2(transform.position.x, transform.position.y); // se empieza igualando el posToGo al start para que los chuzos manetengan su posicion

        end = (Vector2)transform.position + (Vector2.left * offset); /* a diferencia del end anterior, el offset no tiene que ser negativo o algo , porque lo mueve en el vector 2 izquierdo*/
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, posToGo, 10 * Time.deltaTime);
    }

    // con show o hide, lo unico que se hace es switchear entre que valor deben mantener los chuzos con el postogo , ya que constantemente el chuzo esta yendo a un punto el inicio o el fin
    public void Show()
    {
        posToGo = end;
    }

    public void Hide()
    {
        posToGo = start;
    }

}

// los player prefs son para guardar datos en memoria buscar su sintaxis y uso en internet 

