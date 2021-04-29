using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCon01 : MonoBehaviour
{
    public void myLoad0()
    {
        SceneManager.LoadScene(0);
    }
    public void myLoad1()
    {
        SceneManager.LoadScene(1);
    }

    public void myLoad2()
    {
        SceneManager.LoadScene(2);
    }

    public void myExit()
    {
        Application.Quit();
    }
}