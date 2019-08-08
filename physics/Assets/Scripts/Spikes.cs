using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

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
        allLeftSpike = chuzosIzquierda.Count;
        allRigthSpike = chuzosDerecha.Count;
        //chuzosDerecha[(0 - allLeftSpike)].gameObject.SetActive(false);
    }

    private void Update()
    {
        chuzosDerecha[Random.Range(0, allRigthSpike - 1)].gameObject.SetActive(true);
        chuzosIzquierda[Random.Range(0, allLeftSpike- 1)].gameObject.SetActive(true);

    }

    private void OnCollisionEnter(Collision collision)
    {
        //filtar la colision por tag o nombre no se 
    }

}
/*
 un rango para seleccionar todos los elemenos a la vez de la lista y asi depues decirles que los desative
 despues usar el random range para que los chuzos se activen al azar
 luego que se aprezcan segun un en colision enter
hay que volver a desactivar los princhos ´porque se activan y quiedan     
     */