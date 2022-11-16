using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject Door;
    bool SoundOn = true;
   
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            if (SoundOn == true)
            {
                gameObject.GetComponent<AudioSource>().Play();
                Door.transform.parent.GetComponent<Animator>().SetTrigger("Use");
                Door.layer = 0;
                SoundOn = false;
            }
        }
       
       
    }
}
