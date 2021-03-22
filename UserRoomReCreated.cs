using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserRoomReCreated : MonoBehaviour
{
    public GameObject information;
    public UserRoomInfo2 ur;
    public string roomName;
    public int x, y, z = 0;
    // Start is called before the first frame update
    void Start()
    {
        ur = GameObject.Find("UserRoomInformation2").GetComponent<UserRoomInfo2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        ur.roomName = information.transform.Find("RoomNameText").GetComponent<Text>().text;
        ur.x = information.transform.Find("Value").gameObject.GetComponent<Value>().x;
        ur.y = information.transform.Find("Value").gameObject.GetComponent<Value>().y;
        ur.z = information.transform.Find("Value").gameObject.GetComponent<Value>().z;
        ur.call();
    }
}
