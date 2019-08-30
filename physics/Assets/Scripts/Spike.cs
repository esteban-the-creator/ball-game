using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Vector2 start;
    public Vector2 end;
    public float offset = -2;

    private void Awake()
    {
        }

    public void InitializeAsLeft()
    {
        offset = 2;

        start = new Vector2(transform.position.x, transform.position.y); // el transform.position es un vector3 por lo que debe ser casteado, como no permite hacer un casteo general para obtener las dos variables, se castea una a una

        end = (Vector2)transform.position + (Vector2.right * offset); /* al principio la expresión "(Vector2) transform.position"  esta haciendo un casting a vector2 del transform.position, que como se mencionó está en vector3
        y a ese tranform.position en vector2, se le suma un vector2.derecha(osea el eje x normalizado en 1) multiplicado por el valor de la variable offsetRigth (el resultado va a ser que el valor del eje x sera el del ofset rigth, es una multiplicacion por 1*/

    }

    public void InitializeAsRigth()
    {
        offset = 2;

        start = new Vector2(transform.position.x, transform.position.y); // el transform.position es un vector3 por lo que debe ser casteado, como no permite hacer un casteo general para obtener las dos variables, se castea una a una

        end = (Vector2)transform.position + (Vector2.left * offset); /* al principio la expresión "(Vector2) transform.position"  esta haciendo un casting a vector2 del transform.position, que como se mencionó está en vector3
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
