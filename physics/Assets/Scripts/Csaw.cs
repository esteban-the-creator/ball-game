using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Csaw : MonoBehaviour
{
    private Transform SawTransform;

    // Start is called before the first frame update
    void Start()
    {
      SawTransform = this.gameObject.GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        SawTransform.Rotate(0f,0f,10f,Space.Self);
    }
}
