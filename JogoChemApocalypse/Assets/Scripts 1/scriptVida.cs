using UnityEngine;
using UnityEngine.UI;

public class scriptVida : MonoBehaviour
{
    public Slider slider;

    public void setVida(int vida)
    {
        slider.value = vida;
    }

    public void setVidaMax(int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
    }
}
