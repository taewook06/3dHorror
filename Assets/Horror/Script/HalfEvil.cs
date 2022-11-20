using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfEvil : MonoBehaviour
{
    bool EventOn = true;
    public GameObject Evil;
   
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player" && EventOn == true)
        {           
            Evil.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            Invoke("SetFalse", 0.6f);
            EventOn = false;
        }
    }
    void SetFalse()
    {
        Evil.SetActive(false);
    }
}
