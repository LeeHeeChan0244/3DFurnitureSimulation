using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserDefinedRoomEditor : MonoBehaviour
{
    GameObject userRoomInfo2;
    UserRoomInfo2 ur;
    public InputField roomName;
    public InputField x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        userRoomInfo2 = GameObject.Find("UserRoomInformation2");
        if (userRoomInfo2 != null)
        {
            ur = userRoomInfo2.GetComponent<UserRoomInfo2>();
            roomName.text = ur.roomName;
            x.text = ur.x.ToString();
            y.text = ur.y.ToString();
            z.text = ur.z.ToString();

            Destroy(userRoomInfo2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
