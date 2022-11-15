using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Start");
        Destroy(gameObject.GetComponent<Animator>(),4.5f);
        Invoke("CanvasOn", 4.2f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
    void CanvasOn()
    {
        Instantiate(Canvas);
    }
}
