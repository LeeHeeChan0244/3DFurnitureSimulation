using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;



public class AddressSend : MonoBehaviour
{
    public AddressInfo ai;
    public GameObject dropBox;

    WWW www;
    public bool isDownloaded = false;


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
        ai.addressDo = dropBox.GetComponent<ChangedOptions>().optionsDo[dropBox.GetComponent<ChangedOptions>().dropdownDo.value].text;
        ai.addressSi = dropBox.GetComponent<ChangedOptions>().optionsSi[dropBox.GetComponent<ChangedOptions>().dropdownSi.value].text;
        ai.obj = gameObject;
        ai.call();
    }


}



