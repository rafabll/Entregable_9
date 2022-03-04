using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    private float PlayerX;
   

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), 0, 0);


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        
    }
}
