using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ESC;
    public bool ESCOn = false;
    public bool PlayerDie = false;
    public GameObject DieCanvas;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && ESCOn == false)
        {
            //Cursor.lockState = CursorLockMode.Locked; //마우스 커서
            //Cursor.visible = true;

            Cursor.visible = true;

            Time.timeScale = 0f;
            Instantiate(ESC);
            ESCOn = true;
        }
        if (PlayerDie == true)
        {
            player.GetComponent<Animator>().SetTrigger("Use");
            Invoke("die", 3f);
        }         
    }
   
    void die()
    {          
        Time.timeScale = 0f;
        Instantiate(DieCanvas);
        PlayerDie = false;
    }
}
