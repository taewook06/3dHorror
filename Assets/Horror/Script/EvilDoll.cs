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
        Invoke("speed", 2f);
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
}