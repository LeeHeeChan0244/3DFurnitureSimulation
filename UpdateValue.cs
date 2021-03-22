using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateValue : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeValue()
    {
        panel.GetComponent<UpdateInfo>().isUpdated = true;
        Debug.Log("와");
    }

    public void OnEndEdit()
    {
        //panel.GetComponent<UpdateInfo>().isUpdated = true;
    }
}
