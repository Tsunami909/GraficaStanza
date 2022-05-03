using System.Collections;
using UnityEngine;

public class es2 : MonoBehaviour
{
    public GameObject Sphere;
    private GameObject[] objs;
    public int numberOfClone = 10;
    public float fading = 0.1F;

    //usato per inizializzare 

    void Start()
    {
        objs = new GameObject[numberOfClone];
        for(int i = 0; i<numberOfClone; i++)
        {
            objs[i] = (GameObject)Instantiate(Sphere, new Vector3(Random.value, Random.value, Random.value)*5, new Quaternion());
        }
    }

    void Update()
    {
        if(Input.GetKeyDown ("g"))
        {
            StartCoroutine(coroutine_generate());
        }
    }

    IEnumerator coroutine_generate()
    {
        for (int i = 0; i < numberOfClone; i++)
        {
            Color color = objs[i].GetComponent<Renderer>().material.color;
            color.a = Random.value;
            objs[i].GetComponent<Renderer>().material.color = color;

            yield return null;
        }
    }

    IEnumerator delay(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
    }
}