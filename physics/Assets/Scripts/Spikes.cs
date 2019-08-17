using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Vector2 start, end;
    public float offsetRigth = 5;
    
    private void Awake()
    {
        start = new Vector2( transform.position.x, transform.position.y);

        end = (Vector2) transform.position + (Vector2.right * offsetRigth);
    }


    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = Vector2.MoveTowards(transform.position, end, 1f * Time.deltaTime);
        }

        if (Input.GetButton("Fire2"))
        {
            transform.position = Vector2.MoveTowards(transform.position, start, 1f * Time.deltaTime);
        }

    }

}
