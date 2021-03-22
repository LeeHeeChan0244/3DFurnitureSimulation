using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulInfoSend2 : MonoBehaviour
{
    public RoomInfo ri;
    public string address;
    public string addressDoSi;
    public int x, y, z = 0;
    public int roomId = 0;
    public GameObject content;
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
        ri.address = address;
        ri.addressDoSi = addressDoSi;
        ri.roomId = roomId;
        ri.x = x;
        ri.y = y;
        ri.z = z;
        ri.call();
    }
}
