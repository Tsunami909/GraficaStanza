using System.Collections;
using UnityEngine;

public class esercizio2 : MonoBehaviour
{
    public GameObject Cube;
    private GameObject[] objs;
    public int numberOfClone = 10;
    public float fading = 0.1F;

    //usato per inizializzare 

    void Start()
    {
        objs = new GameObject[numberOfClone];
        for(int i = 0; i<numberOfClone; i++)
        {
            objs[i] = (GameObject)Instantiate(Cube, new Vector3(Random.value, Random.value, Random.value)*5, new Quaternion());
        }
    }

    void Update()
    {
        for (int i = 0; i < numberOfClone; i++)
        {
            Color color = objs[i].GetComponent<Renderer>().material.color;
            color.a = Random.value;
            objs[i].GetComponent<Renderer>().material.color = color;
        }
    }
}