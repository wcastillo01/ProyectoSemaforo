﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInvoker : MonoBehaviour
{
    public GameObject[] Garage;
    public Semaforo SemaforoVisto;
      
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("InvocarCarros", 0, 1f);
        
    }

    void InvocarCarros()
    {
        if (SemaforoVisto.run)
        {
            Instantiate(Garage[0], transform.position, Quaternion.identity);
        }
    }
}