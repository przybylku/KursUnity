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
    public Camera cam;
    public Rigidbody rb;

    private Vector3 moveDirection = Vector3.zero;
    Vector2 mousePos;

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
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        /* Ustawienie gravitacji*/
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection);
        
        
        
        
        /*Podązanie celownikiem za myszką || próba1*/
        /*Vector3 lookDir = mousePos -rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;*/

        /*DO ZROBIENIA*/
    }
}
