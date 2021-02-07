using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public void Lento()
    {
        Time.timeScale = 0.2f;

    }

    // Update is called once per frame
    public void Intermedio()
    {
        Time.timeScale = 1;
        
    }

    public void Rapido()
    {
        Time.timeScale = 5;
    }
    public void Detener()
    {
        Time.timeScale = 0;
    }

}
