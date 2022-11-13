using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorNum : MonoBehaviour
{
    public TextMeshProUGUI DoorNumber;
    public bool DoorOn = false;
    int R;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public GameObject light7;

    // Start is called before the first frame update
    void Start()
    {
       R = Random.Range(1, 4);     
    }

    // Update is called once per frame
    void Update()
    {      
        switch (R)
        {
            case 1:
                DoorNumber.text = "3 7 1 5";
                if(light3.activeSelf == true)
                {
                    if(light7.activeSelf == true)
                    {
                        if(light1.activeSelf == true)
                        {
                            if(light5.activeSelf == true)
                            {
                                DoorOn = true;
                            }
                        }
                    }                   
                }
                break;
            case 2:
                DoorNumber.text = "4 2 6 7";
                if (light4.activeSelf == true)
                {
                    if(light2.activeSelf == true)
                    {
                        if(light6.activeSelf == true)
                        {
                            if(light7.activeSelf == true)
                            {
                                DoorOn = true;
                            }
                        }
                    }                    
                }
                break;
            case 3:
                DoorNumber.text = "6 1 5 4";
               if (light6.activeSelf == true)
               {
                    if(light1.activeSelf)
                    {
                        if(light5.activeSelf)
                        {
                            if(light4.activeSelf)
                            {
                                DoorOn = true;
                            }
                        }
                    }                  
               }
                break;
        }
    }
}
