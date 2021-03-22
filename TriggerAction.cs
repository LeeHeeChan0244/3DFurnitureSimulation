using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Located Furniture")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Located Furniture")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
