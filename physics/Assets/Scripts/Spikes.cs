using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Vector2 start, end;
    public float offsetRigth = 2;
    
    private void Awake()
    {
        start = new Vector2( transform.position.x, transform.position.y); // el transform.position es un vector3 por lo que debe ser casteado, como no permite hacer un casteo general para obtener las dos variables, se castea una a una

        end = (Vector2) transform.position + (Vector2.right * offsetRigth); /* al principio la expresión "(Vector2) transform.position"  esta haciendo un casting a vector2 del transform.position, que como se mencionó está en vector3
        y a ese tranform.position en vector2, se le suma un vector2.derecha(osea el eje x normalizado en 1) multiplicado por el valor de la variable offsetRigth (el resultado va a ser que el valor del eje x sera el del ofset rigth, es una multiplicacion por 1*/
    }


    public void Show()
    {
      transform.position = Vector2.MoveTowards(transform.position, end, 10 * Time.deltaTime);
    }

    public void Hide()
    {
      transform.position = Vector2.MoveTowards(transform.position, start, 10f * Time.deltaTime);
    }
}
