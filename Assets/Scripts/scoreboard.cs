using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreboard : MonoBehaviour {
    public static int counter = 0;
   
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt("Score", counter);
        PlayerPrefs.Save();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void scoreincrease() {
        counter +=1;
        this.GetComponent<Text>().text = "" + counter;

        
       
    }
   /* public void scoredecrease()
    {
        counter -= 1;
        this.GetComponent<Text>().text = "" + counter;
    }   
    */
}
