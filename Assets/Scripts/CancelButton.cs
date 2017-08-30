using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CancelButton : MonoBehaviour {

    

	public GameObject screen;
	Spawner spawner ;
    public Text ScoreText;
    int score;
	void Start(){
		spawner = FindObjectOfType<Spawner> ();
	}
	public void OnCancelButtonClicked()
	{
        GameObject.FindObjectOfType<scoreboard>().scoreincrease();
		Destroy (screen);
        
		spawner.screens--;
	}

}
