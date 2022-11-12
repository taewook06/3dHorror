using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorVedio : MonoBehaviour
{
    bool VedioOn = true;
    public GameObject Vedio;
    public GameObject EvilDoll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EvilSpawn()
    {
        Instantiate(EvilDoll);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && VedioOn == true)
        {
            VedioOn = false;
            Instantiate(Vedio);            
            Destroy(GameObject.Find("HorrorVideo(Clone)"), 10f);
            Invoke("EvilSpawn", 10.5f);
            
        }
    }
}
