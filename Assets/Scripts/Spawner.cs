using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Spawner : MonoBehaviour {
	
	public List<GameObject> Screens;
	public Transform CanvasTransform;
	public float screens;
	float random;
	float random2;
	Vector2 wheretoSpawn;
	public float spawnrate = 2f;
	float nextspawn = 0.0f;
    
    // Use this for initialization
    void Start () {

		screens = 0;
	
	}
	
	public void scorelistener()
    {
        if (scoreboard.counter <= 3)
        {
            double rate1 = 2.8;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter >4&&scoreboard.counter<=5)
        {
            double rate1 = 2.6;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter >5 && scoreboard.counter <= 8)
        {
            double rate1 = 2.4;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 10 && scoreboard.counter <= 14)
        {
            double rate1 = 2.2;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 17 && scoreboard.counter <= 22)
        {
            double rate1 = 2;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 22 && scoreboard.counter <= 26)
        {
            double rate1 = 1.8;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter >26 && scoreboard.counter <= 29)
        {
            double rate1 = 1.6;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 33 && scoreboard.counter <= 37)
        {
            double rate1 = 1.5;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 37 && scoreboard.counter <= 41)
        {
            double rate1 = 1.3;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 41 && scoreboard.counter <= 48)
        {
            double rate1 = 1;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 48 && scoreboard.counter <= 53)
        {
            double rate1 = 0.9;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 53 && scoreboard.counter <= 57)
        {
            double rate1 = 0.8;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 57 && scoreboard.counter <=63)
        {
            double rate1 = 0.6;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 63 && scoreboard.counter <= 70)
        {
            double rate1 = 0.4;
            spawnrate = (float)rate1;


        }
        if (scoreboard.counter > 70 && scoreboard.counter <= 77)
        {
            double rate1 = 0.2;
            spawnrate = (float)rate1;


        }


    }

    void Update () {
        scorelistener();
        
		if (Time.time>nextspawn) {


			nextspawn = Time.time + spawnrate;
			random = Random.Range (-500f,500f);
			random2 = Random.Range (-160f,300f);
			wheretoSpawn = new Vector2 (random,random2);

			GameObject prefabToInstantiate = null;
			int randomIndex = Random.Range (0, Screens.Count);
			prefabToInstantiate = Screens [randomIndex];

			GameObject myObj =	Instantiate (prefabToInstantiate,wheretoSpawn,Quaternion.identity) as GameObject;
			myObj.transform.SetParent (CanvasTransform,false);
			myObj.transform.localPosition = wheretoSpawn;
          
            screens++;
		}

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
		if (screens >= 30) 
		{

            SceneManager.LoadScene(2);
        }

        
	}
}
