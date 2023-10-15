using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public void LoadFirstMode()
    {
        //loads the first scene = the normal mode
        SceneManager.LoadScene(1);
    }

    public void LoadSecondMode()
    {
        //loads the second scene = the first hard mode
        SceneManager.LoadScene(2);
    }

    public void LoadThirdMode()
    {
        //loads the third scene = the second hard mode
        SceneManager.LoadScene(3);
    }
}
