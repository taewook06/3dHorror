using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))] //스크립트를 넣으면 자동으로 컴퍼넌트도 얻음.

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float gravity = -9.8f;
    public bool Pmove;

    CharacterController myCharcontroller;

    // Start is called before the first frame update
    void Start()
    {
        
        myCharcontroller = GetComponent<CharacterController>();
        Pmove = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Pmove == true)
        {
            speed = 7f;
        }
        else if(Pmove == true)
        {
            speed = 4f;
        }


        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        myCharcontroller.Move(movement);

    }
       
}
