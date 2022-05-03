using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int moveSpeed = 100;
    public float forceAmount = 1.0f;
    public GameObject Parete4;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       /* if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }*/

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }
        
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }
    }
}

void private OnCollisionEnter(Collision collision)
{
    if(collision.gameObject == Parete4)
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
    }
}