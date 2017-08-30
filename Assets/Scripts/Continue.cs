using UnityEngine;
using System.Collections;

public class Continue : MonoBehaviour {
	Spawner spawner;

    public GameObject panel;
	void Start(){
		spawner = FindObjectOfType<Spawner> ();
	}
	public void OnContinueButtonClicked ()

	{
        
        
        GameObject.FindObjectOfType<Slidercontrol>().SliderDown();
        Destroy (panel);
		spawner.screens--;

	}

}