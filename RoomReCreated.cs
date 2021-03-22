using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomReCreated : MonoBehaviour
{
    public RoomInfo2 ri;
    public string password;
    public string address;
    public string addressDoSi;
    public int x, y, z = 0;
    public GameObject content;
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        addressDoSi = content.GetComponent<AddressSearch>().addressDoSi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        ri.password = password;
        ri.address = address;
        ri.addressDoSi = addressDoSi;
        ri.x = x;
        ri.y = y;
        ri.z = z;
        if(inputField.text.Trim().Equals(password))
            ri.call();
        else
        {
            inputField.text = "";
            return;
        }
    }
}
