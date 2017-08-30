using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScore : MonoBehaviour {

    public Text text; 
	void Start () {

        text.text = PlayerPrefs.GetInt("Score").ToString();



    }

    // Update is called once per frame

}
