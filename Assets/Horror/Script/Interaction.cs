using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interaction : MonoBehaviour
{
    Animator myAni;
    bool isItemOn = false;
    bool keyOn = false;
    bool cry = true;
    bool DoorHorrorSound = true;
    public TextMeshProUGUI E;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    void DoorSound()
    {
        GameObject.Find("HorrorSoundDoor").GetComponent<AudioSource>().Play();
    }
       

    void OnTriggerStay(Collider other)
    {

        if (other.transform.tag == "Door")
        {
            E.text = "(E) Door";
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                //other = null;
            }
        }
        else if (other.transform.tag == "KeyDoor")
        {
            if (keyOn == false)
            {
                E.text = "Find the Key.";
            }
            else if (keyOn == true)
            {
                E.text = "(E) Door";
                if (Input.GetKeyDown(KeyCode.E))
                {                    
                    other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                    // other = null;
                }
            }                   
        }
        else if (other.transform.tag == "Key")
        {
            E.text = "(E) Key";
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.transform.gameObject);
                keyOn = true;
                // other = null;
            }
        }
        else if (other.transform.tag == "DoorClose" && keyOn == true)
        {            
            GameObject.Find("KeyDoor").transform.GetComponent<Animator>().SetTrigger("Use");
            GameObject.Find("DoorClose").GetComponent<AudioSource>().Play();
            keyOn = false;
            //other = null;
        }
        else if (other.transform.tag == "Audio" && cry == true)
        {                
            if (cry == true)
            {
                E.text = "(E) Audio";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    other.transform.gameObject.GetComponent<AudioSource>().Play();
                    // other = null;
                    cry = false;
                }
            }             
        }       
        else if (other.transform.tag == "HorrorSoundDoor" && DoorHorrorSound == true)
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Invoke("DoorSound", 2f);            
            DoorHorrorSound = false;
        }

        if (other.transform.tag == "HarfDoor")
        {
            if (GameObject.Find("DoorNum").GetComponent<DoorNum>().DoorOn == false)
            {
                E.text = "It's not Open.";
            }
            else if (GameObject.Find("DoorNum").GetComponent<DoorNum>().DoorOn == true)
            {
                E.text = "(E) Door";
                if (Input.GetKeyDown(KeyCode.E))
                {     
                    other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                    //other = null;
                }
            }           
        }       
        if(other.transform.tag == "End")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
        }

    }
    void OnTriggerExit(Collider other)
    {
        E.text = "";
    }

}
