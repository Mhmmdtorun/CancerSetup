using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Healthcontrol : MonoBehaviour {

    public static int Healthrate=4;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Healthrate<=0)
        {
            Debug.Log("Oyun Bitti");
        }
	}
    public void healthdecrease()
    {
        Healthrate -= 1;
        this.GetComponent<Text>().text = Healthrate.ToString();


    }

}
