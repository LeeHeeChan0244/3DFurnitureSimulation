using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmItem : MonoBehaviour
{
    public GameObject locatedUI;
    public GameObject listUI;
    public GameObject target;

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
       locatedUI.GetComponent<LocatingManager>().ModifyInfo(target);
        listUI.SetActive(true);
        locatedUI.SetActive(false);
    }
    
}
