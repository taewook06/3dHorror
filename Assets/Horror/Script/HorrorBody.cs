using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorBody : MonoBehaviour
{
    bool HorrorEvent = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (HorrorEvent == true)
        {
            transform.Translate(0, 0.01f, -0.0036f);
            Destroy(gameObject, 9f);
            gameObject.GetComponent<AudioSource>().Play();
        }             
    }   
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            HorrorEvent = true;
        }
       
    }
}
