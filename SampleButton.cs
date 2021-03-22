using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleButton : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        manager.GetComponent<CategoryManage>().SetToSample();
    }
}
