using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void PlayGame (int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("quit");
    }

}
