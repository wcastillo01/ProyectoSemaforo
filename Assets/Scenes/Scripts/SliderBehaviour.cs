using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    public Slider mySlider;
    public float valor;

    public void SliderControl()
    {
        valor = mySlider.value;
        Time.timeScale = valor;
    }

}
