using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public List<GameObject> chuzosIzquierda;
    public List<GameObject> chuzosDerecha;
    [SerializeField]
    private int allRigthSpike;
    [SerializeField]
    private int allLeftSpike;

    private void Awake()
    {
        chuzosIzquierda = new List<GameObject>(GameObject.FindGameObjectsWithTag("SpikesLeft"));
        chuzosDerecha = new List<GameObject>(GameObject.FindGameObjectsWithTag("SpikerRigth"));
        
    }

    void Start()
    {
        chuzosDerecha.ForEach( e => e.SetActive(false) );//estos son foreach de programacion lambda (programacion nueva para c# y permiten realizar lo mismo que el foreach anterior (INDICE1), pero en este caso el sistema deduce el tipo de varible que en este caso se llama "e" pero en el otro caso era "item"
        chuzosIzquierda.ForEach( e => e.SetActive(false) );

        allLeftSpike = chuzosIzquierda.Count; // con la funcion count de la lista se puede contar la cantidad de elemntos que hay en ella y en eset caso guardarlos en una variable; no hago nada con ella pero es bueno recordarlo
    }

}
/*
    seleccionar unas espinas al azar , guardar cuales son en un indice, decirles que se muevan con move towards, indicarle a las espinaz que con collion enter(pero para esto necesito que el objeto tenga rigidbody de su lado
    se descativen (para esto es la variable) y se haga el mismo proceso para espinas del otro lado
     */


/* INDICE 1
 
   //Estos son los foreach originales de C#, permiten indicar que para cada VAR(tipo de variable, puede ser int gameobject, etc) que llamaremos item , o como
   //se prefiera, dentro de una variable, clase, objeto o coleccion, en este caso la lista, se ejecute algo, en este caso, desactive los items contenidos en esa lista

        foreach (GameObject item in chuzosDerecha)
        {
            item.SetActive(false);
        }

        foreach (var item in chuzosIzquierda)
        {
            item.SetActive(false);
        }
        chuzosDerecha[(0 - allLeftSpike)].gameObject.SetActive(false); */
