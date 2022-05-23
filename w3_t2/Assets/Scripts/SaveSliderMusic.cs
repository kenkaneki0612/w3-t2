using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSliderMusic : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("save_slider_music", sliderValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSliderMusic(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("save_slider_music", sliderValue);
    }
}
