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
                DoorNumber.text = "1 3 5 7";
                if(light1.activeSelf == true && light3.activeSelf == true && light5.activeSelf == true && light7.activeSelf == true)
                {
                    DoorOn = true;
                }
                break;
            case 2:
                DoorNumber.text = "2 4 6 7";
                if (light2.activeSelf == true && light4.activeSelf == true && light6.activeSelf == true && light7.activeSelf == true)
                {
                    DoorOn = true;
                }
                break;
            case 3:
                DoorNumber.text = "1 4 5 6";
               if (light1.activeSelf == true && light4.activeSelf == true && light5.activeSelf == true && light6.activeSelf == true)
               {
                    DoorOn = true;
               }
                break;
        }
    }
}
