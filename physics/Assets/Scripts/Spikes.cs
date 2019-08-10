using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    Vector2 position1;
    Vector2 start, end;
    public GameObject ToGo;
    float offset = 0.2f;


    private void Awake()
    {
        ToGo = GameObject.FindGameObjectsWithTag("");
    }


    private void Update()
    {
        start = transform.position;
        end = ToGo.transform.position;

        transform.position = Vector2.MoveTowards(start, end, 5 * Time.deltaTime);

        if (transform.position < ToGo)
        {
            Debug.Log("Sirve");
           
        }

    }

}
