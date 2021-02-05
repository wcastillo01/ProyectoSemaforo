using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{

    public GameObject luzVerde;
    public GameObject luzAmarilla;
    public GameObject luzRoja;
    public bool run = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(semaforo());   
    }

    public void LuzVerde()
    {
        luzVerde.SetActive(true);
        luzAmarilla.SetActive(false);
        luzRoja.SetActive(false);
        run = true;
    }

    public void LuzAmarilla()
    {
        luzVerde.SetActive(false);
        luzAmarilla.SetActive(true);
        luzRoja.SetActive(false);
        
    }

    public void LuzRoja()
    {
        luzVerde.SetActive(false);
        luzAmarilla.SetActive(false);
        luzRoja.SetActive(true);
        run = false;
    }


    IEnumerator semaforo()
    {
        while (true)
        {

            LuzVerde();
            yield return new WaitForSeconds(1);

            LuzAmarilla();
            yield return new WaitForSeconds(1);

            LuzRoja();
            yield return new WaitForSeconds(2);


        }
    }
}
