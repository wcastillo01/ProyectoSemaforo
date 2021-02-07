using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCar2 : MonoBehaviour
{

    public GameObject run;
    public bool pase;

    void Start()
    {
        run = GameObject.Find("semaforo2");
        pase = false;
        transform.Rotate(0, 0, 180, Space.Self);
   
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

        if (collision.tag == "Collider2")
        {
            pase = true;
        }

    }
}
