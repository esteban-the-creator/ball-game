using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour

{
    public List<GameObject> chuzos = new List<GameObject>();
    [SerializeField]
    private int allSpikes;
    private int RndomSpike1;
    public sideOfSpikes mySide; // se llama al enum que está publico en el mundo (el mundo del script, osea más abajo, aunque esto no es una instancia) y se usa como variable para determinar el lado (Der. o Izq), manualmente desde el inspector de unity


    private void Awake()
    {
     /* este foreach asigna los chuzos del mundo a la lista

        foreach (Transform item in this.transform) // a los Transform que llamamos item (podría llamarse chuzo) en el transform del hijo (el 0 significa que es el primer hijo) del transform en donde esta aplicado este código (el padre)
        {
            chuzos.Add(item.gameObject); // se añade a la lista llamada chuzos, se llama el gameobject del Transform "item" (osea los chuzos) porque todos los tranform tiene gameobject y todos los gameobject tienen tranform
        }
        */


        // aca se diferencia si los chuzos son Izq o Derc

        if (mySide == sideOfSpikes.Izquierda)
        {
            chuzos.ForEach((spike) => spike.GetComponent<Spike>().InitializeAsLeft());
        }
        else
        {
            chuzos.ForEach((spike) => spike.GetComponent<Spike>().InitializeAsRigth());
        }
    }

    void Start()
    {
       //chuzos.ForEach(e => e.SetActive(false)); //estos son foreach de programacion lambda (programacion nueva para c# y permiten realizar lo mismo que el foreach anterior (INDICE1), pero en este caso el sistema deduce el tipo de varible que en este caso se llama "e" pero en el otro caso era "item" 
       allSpikes = chuzos.Count; // con la funcion count de la lista se puede contar la cantidad de elemntos que hay en ella y en eset caso guardarlos en una variable; no hago nada con ella pero es bueno recordarlo
    }

    

    public void EnableSpikes()
    {
        RndomSpike1 = Random.Range(0, allSpikes - 1);

        chuzos[RndomSpike1].GetComponent<Spike>().Show();
    }

    public void HideSpikes()
    {
        chuzos.ForEach(e => e.GetComponent<Spike>().Hide());

    }

    /*
    seleccionar unas espinas al azar , guardar cuales son en un indice, decirles que se muevan con move towards, 
    indicarle a las espinaz que con collion enter(pero para esto necesito que el objeto tenga rigidbody de su lado
    se descativen (para esto es la variable) y se haga el mismo proceso para espinas del otro lado
     */
}

public enum sideOfSpikes
{
    Izquierda,
    Derecha
}

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
