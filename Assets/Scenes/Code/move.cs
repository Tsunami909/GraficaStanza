using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int moveSpeed = 100;
    public float forceAmount = 10.0f;
    public GameObject Parete1;
    public GameObject Parete2;
    public GameObject Parete4;
    public GameObject PareteCentrale;
    public GameObject PareteLungaInt1;
    public GameObject PareteLungaInt2;
    public GameObject ParetePiccolaInt1;
    public GameObject ParetePiccolaInt2;
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == Parete4)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        if(collision.gameObject == PareteCentrale)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        if(collision.gameObject == PareteLungaInt1)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        if(collision.gameObject == PareteLungaInt2)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        if(collision.gameObject == ParetePiccolaInt1)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }
        if(collision.gameObject == ParetePiccolaInt2)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject == Parete1)
        {
            Destroy(Parete1);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject == Parete2)
        {
            Parete2.GetComponent<Renderer>().material.color = Color.Lerp(Parete2.GetComponent<Renderer>().material.color, new Color(Random.value, Random.value, Random.value, Random.value), Random.value);
        }
    }

    
}

