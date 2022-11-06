using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    Animator myAni;
    bool isItemOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Door")
        {
            Debug.Log("111111");
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.transform.parent.GetComponent<Animator>().SetTrigger("Use");
            }
        }      
        
    }
}
