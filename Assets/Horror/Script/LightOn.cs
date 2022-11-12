using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject lightObj;

    public IEnumerator playerCheckCoroutine;

    public void Start()
    {
        playerCheckCoroutine = PlayerIn();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            StartCoroutine(playerCheckCoroutine);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            StopCoroutine(playerCheckCoroutine);
        }
    }

    IEnumerator PlayerIn()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (lightObj.activeSelf == true)
                {
                    lightObj.SetActive(false);
                }
                else if (lightObj.activeSelf == false)
                {
                    lightObj.SetActive(true);
                }
            }


            yield return null;
        }
    }

}
