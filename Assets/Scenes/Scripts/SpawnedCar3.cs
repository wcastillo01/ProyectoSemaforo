using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCar3 : MonoBehaviour
{
   
    public GameObject run;
    public bool pase;

    void Start()
    {
        run = GameObject.Find("semaforo3");
        pase = false;
        transform.Rotate(0, 0, 180, Space.Self);

    }

    void Update()
    {

        if (run.GetComponent<SemaforoVertical>().run || pase)
        {
            transform.Translate(Vector2.up * 2.4f * Time.deltaTime, Space.Self);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

        
        if (collision.tag == "Collider3")
        {
            pase = true;
        }
        
    }
}
