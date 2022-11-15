using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilDollHit : MonoBehaviour
{
    bool diying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(diying == true)
        {            
            transform.parent.Translate(0, -0.7f, 0);
        }
       
    }
    void Die()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
    }
   
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Bullet")
        {
            diying = true;
            gameObject.transform.parent.gameObject.GetComponent<NavMeshAgent>().speed = 0f;
            gameObject.transform.parent.GetComponent<Animator>().SetBool("Die", true); //죽음           
            Invoke("Die", 4f);
        }
        if (other.transform.tag == "Player")
        {
            gameObject.transform.parent.gameObject.GetComponent<NavMeshAgent>().speed = 0f;
            gameObject.transform.parent.GetComponent<Animator>().SetBool("Attack",true); //공격
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerDie = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            gameObject.transform.parent.GetComponent<NavMeshAgent>().speed = 5f;
            gameObject.transform.parent.GetComponent<Animator>().SetBool("Attack", false); //공격
                                                                                           
        }
    }


}
