using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionToWall : MonoBehaviour
{
    private Material original;
    public Material change;
    // Start is called before the first frame update
    void Start()
    {
        original = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Located Furniture")
        {
            gameObject.GetComponent<MeshRenderer>().material = change;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = original;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Located Furniture")
        {
            gameObject.GetComponent<MeshRenderer>().material = change;
        }
    }
}
