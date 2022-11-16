using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject DeadBody;
    public GameObject Door;
    public GameObject Chair;
    public GameObject lightOn;

    float f;
    bool IsChair = true;
    bool IsDoor = true;
    bool lights = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        f += Time.deltaTime;

        if(f>4 && f<8)
        {
            bodyOn();
        }

        if(f>11 && IsChair == true)
        {          
          Instantiate(Chair);
          IsChair = false;                  
        }

        if(f > 13.7f)
        {
            Destroy(GameObject.Find("ChairLight(Clone)").GetComponent<Animator>());
        }
        if(f>16 && lights ==true)
        {
            lightOn.SetActive(true);
            lights = false;
        }

        if(f > 17 && IsDoor == true)
        {
            Door.GetComponent<Animator>().SetTrigger("Use");
            IsDoor = false;
        }
    }
    void bodyOn()
    {
        DeadBody.transform.Translate(0.0015f, 0.0015f, 0);
    }
}
