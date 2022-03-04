using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //private SaveInfo saveInfoScript;
    public void ChangeTo2()
    {
        //saveInfoScript = GameObject.Find("Cube").GetComponent<transform.position.x>();
        SceneManager.LoadScene("SampleScene 2");
    }

    public void ChangeTo1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
