using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    Animator myAni;
    bool isItemOn = false;
    bool keyOn = false;
    bool cry = true;
    bool DoorHorrorSound = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameObject.Find("DoorNum"));
        Debug.Log(GameObject.Find("DoorNum").GetComponent<DoorNum>());
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
        
        if (other.transform.tag == "Door" && Input.GetKeyDown(KeyCode.E))
        {

            other.transform.parent .GetComponent<Animator>().SetTrigger("Use");
            //other = null;
        }
        else if (other.transform.tag == "KeyDoor" && Input.GetKeyDown(KeyCode.E) && keyOn == true)
        {
            other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
           // other = null;
        }
        else if (other.transform.tag == "Key" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(other.transform.gameObject);
            keyOn = true;
           // other = null;
        }
        else if (other.transform.tag == "DoorClose" && keyOn == true)
        {            
            GameObject.Find("KeyDoor").transform.GetComponent<Animator>().SetTrigger("Use");
            GameObject.Find("DoorClose").GetComponent<AudioSource>().Play();
            keyOn = false;
            //other = null;
        }
        else if (other.transform.tag == "Audio" && Input.GetKeyDown(KeyCode.E) && cry == true)
        {
            other.transform.gameObject.GetComponent<AudioSource>().Play();          
           // other = null;
            cry = false;
        }       
        else if (other.transform.tag == "HorrorSoundDoor" && DoorHorrorSound == true)
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Invoke("DoorSound", 2f);            
            DoorHorrorSound = false;
        }

        if (other.transform.tag == "HarfDoor" && Input.GetKeyDown(KeyCode.E) && GameObject.Find("DoorNum").GetComponent<DoorNum>().DoorOn == true)
        {
            other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
            //other = null;
        }       
        if(other.transform.tag == "End")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
