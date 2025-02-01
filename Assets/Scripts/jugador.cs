using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{

    CharacterController character;

    public float walk = 06.0f;
    public float jump = 10f;
    public float gravity = 15f;
    public float run = 25f;

    public Camera camara;
    public float horizontal = 20.0f;
    public float vertical = 2.0f;
    public float Rotacionmaxima = 40.0f;
    public float Rotacionminima = 20.0f;
    float h_mou, y_mou;

    private Vector3 movimiento = Vector3.zero;
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        h_mou = vertical * Input.GetAxis("Mouse Y");
        y_mou = horizontal * Input.GetAxis("Mouse X");

        if (character.isGrounded){
            movimiento = transform.TransformDirection(movimiento) * run;

        }
        else
        {
            movimiento = transform.TransformDirection(movimiento) * walk;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            movimiento.y = jump;
        }

        movimiento.y -= gravity * Time.deltaTime;
        character.Move(movimiento * Time.deltaTime);

    }
}
