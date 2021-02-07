
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCar1 : MonoBehaviour
{

    public GameObject run;
    public bool pase;

    void Start()
    {
        run = GameObject.Find("semaforo1");
        pase = false;
    }

    void Update()
    {

        if (run.GetComponent<Semaforo>().run || pase)
        {
            transform.Translate(Vector2.right * 2.5f * Time.deltaTime, Space.Self);
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Collider1")
        {
            pase = true;

        }

    }
}