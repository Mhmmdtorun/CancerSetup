using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour {
     
   
    
    public void ButtonStart(string newGamelevel)
    {
        SceneManager.LoadScene(newGamelevel);


    }
    public void GameQuit()
    {

        Application.Quit();
    }

    private void Update()
    {
        
    }

}
