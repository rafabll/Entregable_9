using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeTo2()
    {        
        SceneManager.LoadScene("SampleScene 2");
    }

    public void ChangeTo1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
