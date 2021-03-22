using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCreator : MonoBehaviour
{
    public AddressInfo ai;
    public GameObject dropBox;

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
        ai.call();
    }
}
