using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserRoomInfoSend : MonoBehaviour
{
    public UserRoomInfo ur;
    public string roomName;
    public int x, y, z = 0;
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
        ur.roomName = roomName;
        ur.x = x;
        ur.y = y;
        ur.z = z;
        ur.call();
    }
}
