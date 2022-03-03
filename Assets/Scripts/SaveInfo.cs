using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    private float PlayerX;
    
    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), 0, 0);
    }
    void Uptade()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);       
    }
}
