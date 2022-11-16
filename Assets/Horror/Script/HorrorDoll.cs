    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorDoll : MonoBehaviour
{
    public GameObject Doll;   
    bool HorrorEventOn = true;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Speed()
    {
        player.GetComponent<PlayerMove>().Pmove = true;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && HorrorEventOn == true)
        {
            player.GetComponent<PlayerMove>().Pmove = false;
            player.GetComponent<PlayerMove>().speed = 0f;
            Instantiate(Doll);
            Destroy(GameObject.Find("HorrorDoll(Clone)"), 6f);
            Invoke("Speed", 6f);
            HorrorEventOn = false;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
