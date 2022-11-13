using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorEvil : MonoBehaviour
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
            transform.Translate(0f, 0f, 0.04f);
            Destroy(gameObject, 7f);            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            HorrorEvent = true;
        }
    }
}
