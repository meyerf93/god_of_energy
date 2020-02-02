using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
    public Text displayTexte;
    public Slider sliderValue;

    public void changeText()
    {
        string temp_value = sliderValue.value.ToString();
        //print("Temp value slider : " + temp_value);
        displayTexte.text = sliderValue.value.ToString();
    }
}
