using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LVL1()
    {
        SceneManager.LoadScene(1);
    }

    public void Opciones()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

    public void LVL2()
    {
        SceneManager.LoadScene(4);
    }

    public void LVL3()
    {
        SceneManager.LoadScene(5);
    }
}

