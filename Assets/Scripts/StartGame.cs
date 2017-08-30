using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

    public void ButtonStart(string newGamelevel)
    {
        SceneManager.LoadScene(newGamelevel);


    }



}