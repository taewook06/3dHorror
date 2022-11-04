using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorChair : MonoBehaviour
{
    public GameObject HorrorDollPrefabs;
    public GameObject Spawner;
    public GameObject Spawner1;
    GameObject Spawner2;

    bool HorrorDollEvent = false;
    // Start is called before the first frame update
    void Start()
    {       
        Spawner2 = this.gameObject;
        Instantiate(HorrorDollPrefabs, Spawner.transform.position , Spawner.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(HorrorDollEvent == true)
        {
            Destroy(GameObject.Find("HorrorDoll(Clone)"));
            //Doll�� �������� ����1�� �����ϰ� 1.5�ʵ� �����          

            //Doll�� �������� ����2�� �����ϰ� 1.5�ʵ� �����

         

            HorrorDollEvent = false;
        }
    }    
    void HorrorChairEvent1()
    {
        Instantiate(HorrorDollPrefabs, Spawner1.transform.position, Spawner.transform.rotation);//Quaternion.identity ȸ�� x
        Destroy(GameObject.Find("HorrorDoll(Clone)"), 1.5f);
    }
    void HorrorChairEvent2()
    {
        Instantiate(HorrorDollPrefabs, Spawner2.transform.position, Spawner.transform.rotation);
        Destroy(GameObject.Find("HorrorDoll(Clone)"), 1.0f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HorrorDollEvent = true;
        }
    }
}
