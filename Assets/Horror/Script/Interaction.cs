using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{      
    private IEnumerator coroutine;
    GameObject ThisInteract;
    TextMeshProUGUI E;

    bool keyOn = false;
    bool cry = true;
    bool DoorHorrorSound = true;

    void Start()
    {
        coroutine = Interact();
        E = GameObject.Find("Canvas").transform.GetComponentInChildren<TextMeshProUGUI>();
    }    
    IEnumerator Interact()
    {
        while(true)
        {            
            if(ThisInteract.tag == "Key" && keyOn == false)
            {
                E.text = "(E) Key";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    keyOn = true;                    
                    Destroy(ThisInteract.transform.gameObject);
                    ThisInteract = null;
                    E.text = "";
                    break;
                }                   
            }
            else if (ThisInteract.tag == "Door")
            {
                E.text = "(E) Door";
               if (Input.GetKeyDown(KeyCode.E))
               {
                    ThisInteract.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                    break;
                }
            }
            else if(ThisInteract.tag == "HarfDoor")
            {
                if (GameObject.Find("DoorNum").GetComponent<DoorNum>().DoorOn == false)
                {
                    E.text = "It's not Open.";
                    break;
                }
                else if (GameObject.Find("DoorNum").GetComponent<DoorNum>().DoorOn == true)
                {
                    E.text = "(E) Door";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        ThisInteract.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                        break;
                    }
                }
            }
            else if(ThisInteract.tag == "KeyDoor")
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
                        ThisInteract.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                        break;
                    }
                }
            }
            else if(ThisInteract.tag == "Audio" && cry == true)
            {
              
                E.text = "(E) Audio";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ThisInteract.transform.gameObject.GetComponent<AudioSource>().Play();
                    cry = false;
                    break;
                }
              
            }         
            else if(ThisInteract.tag == "HorrorDoorSound" )
            {                
                ThisInteract.gameObject.GetComponent<AudioSource>().Play();
                Invoke("DoorSound", 2f);
                DoorHorrorSound = false;
            
            }
            else if (ThisInteract.tag == "DoorClose")
            {
                GameObject.Find("KeyDoor").transform.GetComponent<Animator>().SetTrigger("Use");
                GameObject.Find("DoorClose").GetComponent<AudioSource>().Play();
                keyOn = false;
               
            }
            else if(ThisInteract.tag == "LightBtn")
            {
                E.text = "(E) Light";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ThisInteract.GetComponent<LightOn>().IsLight();
                }             
                
            }
                yield return null;
        }
    }  
    void DoorSound()
    {
        GameObject.Find("HorrorSoundDoor").GetComponent<AudioSource>().Play();
    }
    void OnTriggerEnter(Collider other)
    {       
        if (other.gameObject.layer == 3)
        {
            ThisInteract = other.gameObject;
            coroutine = Interact();
            StartCoroutine(coroutine);
        }            
    }
    void OnTriggerExit(Collider other)
    {       
        if (other.gameObject.layer == 3)
        {
            StopCoroutine(coroutine);
            ThisInteract = null;
            E.text = "";
        }        
    }
}
