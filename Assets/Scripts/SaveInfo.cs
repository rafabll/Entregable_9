using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    public float PosX;
    public float PosY;
    public float PosZ;

    public Vector3 position;

    void Start()
    {
        PosX = PlayerPrefs.GetFloat("PlayerX");
        PosY = PlayerPrefs.GetFloat("PlayerY");
        PosZ = PlayerPrefs.GetFloat("PlayerZ");
        position.x = PosX;
        position.y = PosY;
        position.z = PosZ;
        transform.position = position;
    }
    void Uptade()
    {                
            PlayerPrefs.SetFloat("PlayerX", transform.position.x);
            PlayerPrefs.SetFloat("PlayerY", transform.position.y);
            PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
            Debug.Log("Datos Guardados");        
    }    
}
