using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInvokerVertical : MonoBehaviour
{
    public GameObject[] Garage;
    public SemaforoVertical SemaforoVisto;
    float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("InvocarCarros", 0, 1);
        
    }

    void InvocarCarros()
    {

        if (SemaforoVisto.run)
        {
            Instantiate(Garage[0], transform.position, Quaternion.identity);
        }
     
    }
}
