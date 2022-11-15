using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainOn()
    {
        //Cursor.lockState = CursorLockMode.Locked; //마우스 커서
        //Cursor.visible = true;

        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
        GameObject.Find("GameManager").GetComponent<GameManager>().ESCOn = false;
    }
}
