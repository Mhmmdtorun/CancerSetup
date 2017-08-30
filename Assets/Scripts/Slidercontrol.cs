using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slidercontrol : MonoBehaviour {
    public Slider Slider;
    // Use this for initialization
    void Start () {
	
	}
	
   
	public void SliderDown()
    {
        Slider.value -=2;

    }
	void Update () {
        Slider.value = Slider.value + Time.deltaTime/4;
        if (Slider.value==100)
        {
            SceneManager.LoadScene(3);
        }
    }
}
