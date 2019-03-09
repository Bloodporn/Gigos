using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{

    public float maxValue = 100;
    public Color color = Color.red;
    public int width = 4;
    public Slider slider;
    public bool isRight;

    private static float current;

    void Start()
    {
        slider.fillRect.GetComponent<Image>().color = color;

        slider.maxValue = maxValue;
        slider.minValue = 0;
        current = maxValue;

    }

    public static float currentValue
    {
        get { return current; }
    }

    void Update()
    {
        if (current < 0) current = 0;
        if (current > maxValue) current = maxValue;
        slider.value = current;
    }

    public static void AdjustCurrentValue(float adjust)
    {
        current = adjust;
    }
}

