using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
   
    // Start is called before the first frame update
    void Start()
    {     
        int KeySpawnNum = Random.Range(1, 4);
        switch(KeySpawnNum)
        {
            case 1:
                Instantiate(key1);               
                break;
            case 2:
                Instantiate(key2);                
                break;
            case 3:
                Instantiate(key3);             
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
