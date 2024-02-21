using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private int contador;

    //public GameObject ball;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MoreMass")
        {
            contador += 1;
            Debug.Log(contador);
        }
    }

    void FixedUpdate()
    {

        //si variable contador % numero x = 0 si  jala
        if((contador % 3 == 0) && contador != 0)
        {
            rb.mass += 3f;
            contador = 0;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Safe")
        {
            rb.mass = 1f;
        }

        if (collision.gameObject.tag == "Finish")
        {
            Camera.main.transform.SetParent(null);
            gameObject.SetActive(false);
        }
    }
}
