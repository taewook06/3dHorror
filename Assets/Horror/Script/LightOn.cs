using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject lightObj;
   
    void Start()
    {
       
    }
    public void IsLight()
    {
        if(lightObj.activeSelf == false)
        {            
            lightObj.SetActive(true);
        }
        else if(lightObj.activeSelf == true)
        {            
            lightObj.SetActive(false);
        }
    }   
}
