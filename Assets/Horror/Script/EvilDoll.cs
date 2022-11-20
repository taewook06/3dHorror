using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilDoll : MonoBehaviour
{
    NavMeshAgent agant;

    [SerializeField]
    Transform target;
    
    // Start is called before the first frame update
    void Awake()
    {
        agant = GetComponent<NavMeshAgent>();
    }
     void Start()
     {
        gameObject.GetComponent<NavMeshAgent>().speed = 0f;
        Invoke("speed", 4f);
     }

    // Update is called once per frame
    void Update()
    {        
       target = GameObject.Find("player").transform;
       agant.SetDestination(target.position);       
    }

    void speed()
    {
        gameObject.GetComponent<NavMeshAgent>().speed = 5f;
    }
    void OnTriggerStay(Collider other)
    {
        if(other.transform.tag == "Player")//¶Ù¾î´Ù´Ô
        {
            //gameObject.GetComponent<NavMeshAgent>().speed = 3f;
            gameObject.transform.GetComponent<Animator>().SetBool("Run", true);
        }                
    }    
    void OnTriggerExit(Collider other)
    {
        //gameObject.GetComponent<NavMeshAgent>().speed = 5f;
        gameObject.transform.GetComponent<Animator>().SetBool("Run", false); //±â¾î´Ù´Ô
    }

}
