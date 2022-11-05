using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorDoll : MonoBehaviour
{
    public GameObject Doll1;
    public GameObject Doll2;
    public GameObject Doll3;
    public GameObject Ghost;

    bool HorrorEventOn = true;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Doll1);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void HorrorEvent()
    {
        Destroy(GameObject.Find("HorrorDoll1(Clone)"));
        Invoke("DollTwoMake", 1.5f);
        Invoke("DollTwo", 3f);
        HorrorEventOn = false;
    }
    void DollTwoMake()
    {
        Instantiate(Doll2);
    }
    void DollTwo()
    {
        
        Destroy(GameObject.Find("HorrorDoll2(Clone)"));
        Invoke("DollThreeMake", 1.5f);
        Invoke("DollThree", 3f);
    }
    void DollThreeMake()
    {
        Instantiate(Doll3);
    }
    void DollThree()
    {
        Destroy(GameObject.Find("HorrorDoll3(Clone)"));
        Instantiate(Ghost);
        Destroy(GameObject.Find("HorrorImageEvent(Clone)"), 0.5f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && HorrorEventOn == true)
        {
            HorrorEvent();
        }
    }
}
