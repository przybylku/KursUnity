using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    /*Dokumentacja
        Do obiektu, którego chcemy zrobić jako gracza musimy dodać komponent CharacterController *Wymagane*
        */
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Poruszanie się*/
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
        }
        /* Ustawienie gravitacji*/
        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection);
    }
}
