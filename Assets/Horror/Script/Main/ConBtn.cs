using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ConOn()
    {
        //Cursor.lockState = CursorLockMode.Locked; //마우스 커서
        //Cursor.visible = false;

        Cursor.visible = false;

        Time.timeScale = 1f;
        Destroy(GameObject.Find("CanvasESC(Clone)"));
        GameObject.Find("GameManager").GetComponent<GameManager>().ESCOn = false;
    }
}
