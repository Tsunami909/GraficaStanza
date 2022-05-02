using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int moveSpeed = 10;
    public float forceAmount = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
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
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKeyDown("a"))
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKeyDown("d"))
        {
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }
        
        if(Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }
    }
}