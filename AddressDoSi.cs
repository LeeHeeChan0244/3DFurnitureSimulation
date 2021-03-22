using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddressDoSi : MonoBehaviour
{
    GameObject addressInfo;
    GameObject roomInfo;
    AddressInfo ai;
    RoomInfo2 ri;

    //public string Do;
    //public string Si;
    public Text DoSi;
    
    public InputField password;
    public InputField address;
    public InputField x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        addressInfo = GameObject.Find("AddressInformation");
        if (addressInfo != null)
        {
            ai = addressInfo.GetComponent<AddressInfo>();

            //Do = ai.addressDo;
            //Si = ai.addressSi;

            DoSi.text = ai.addressDo + " " + ai.addressSi;
            Destroy(addressInfo);
        }
        else
        {
            roomInfo = GameObject.Find("RoomInformation2");
            ri = roomInfo.GetComponent<RoomInfo2>();

            DoSi.text = ri.addressDoSi;
            password.text = ri.password;
            address.text = ri.address;
            x.text = ri.x.ToString();
            y.text = ri.y.ToString();
            z.text = ri.z.ToString();

            Destroy(roomInfo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
