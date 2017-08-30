using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HealthControl : MonoBehaviour {

    public static int health;

	public void Death()
	{
		

	}
	void Start () {
	
	}
	public void Healthdecrease()
    {
        health -=1;
        this.GetComponent<Text>().text =health.ToString();
    }   
	
	void Update () {
		
	}
}
