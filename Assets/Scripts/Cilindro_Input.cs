using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cilindro_Input : MonoBehaviour
{
    PlayerInput playerInput;

    InputAction girar;

    [SerializeField] float speed;

    //private float angleOfRotation;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        girar = playerInput.actions.FindAction("Rotar");
    }

    void Update()
    {
        Girar();
    }

    void Girar()
    {
        Vector2 direction = girar.ReadValue<Vector2>();
        transform.position +=  new Vector3(-direction.x, 0, -direction.y) * speed * Time.deltaTime;
        //Debug.Log(girar.ReadValue<Vector2>());
    }
}
