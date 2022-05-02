using System.Collections;
using UnityEngine;

public class Ciao : MonoBehaviour
{
    public int moveSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Il Time.deltaTime serve per far visualizzare bene tutto il movimento dell'oggetto senza farlo "schizzare"
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed*Time.deltaTime);
        }
    }
}