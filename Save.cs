using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class Save : MonoBehaviour
{
    public GameObject plane;
    public GameObject list;
    public string info;
    WWW www;

    GameObject userRoomInfo;
    GameObject createdRoomInfo;
    GameObject roomInfo;
    RoomInfo ri;
    UserRoomInfo ur;
    CreatedRoomInfo cr;
    public bool isUR = true;
    public int x, y, z;
    public string addressDoSi;
    public string address;
    public int roomId;
    public string roomName;
    public string password;

    public string rid;


    // Start is called before the first frame update
    void Start()
    {
        userRoomInfo = GameObject.Find("UserRoomInformation");
        roomInfo = GameObject.Find("RoomInformation");
        createdRoomInfo = GameObject.Find("CreatedRoomInformation");
        StartCoroutine(LaSend());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        LocatedListBlock[] blocks = list.GetComponentsInChildren<LocatedListBlock>();
        if (createdRoomInfo != null)
        {
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            cr = createdRoomInfo.GetComponent<CreatedRoomInfo>();
            //addressDoSi = cr.addressDoSi;
            //address = cr.address;
            x = cr.x;
            y = cr.y;
            z = cr.z;
            roomId = cr.roomId;
            Destroy(createdRoomInfo);
            //password = cr.password;
            //Debug.Log(roomId + "fuck");
        }
        else if (roomInfo != null)
        {
            ri = roomInfo.GetComponent<RoomInfo>();
            x = ri.x;
            y = ri.y;
            z = ri.z;
            roomId = ri.roomId;
            Destroy(roomInfo);
        }
        else if (userRoomInfo != null)
        {
            ur = userRoomInfo.GetComponent<UserRoomInfo>();
            x = ur.x;
            y = ur.y;
            z = ur.z;
            roomName = ur.roomName;
            List<LocalData> itemList = new List<LocalData>();
            itemList.Add(new LocalData((plane.transform.localScale.x * 1000).ToString(), (plane.transform.localScale.z * 1000).ToString(), "1", 0, 0, 0, 0, "0"));
            JsonData itemJson = JsonMapper.ToJson(itemList);
            PlayerPrefs.SetString("roomList", PlayerPrefs.GetString("roomList", null) + "," + roomName);
            PlayerPrefs.Save();
            for (int i = 0; i < blocks.Length; i++)
            {
                Debug.Log("!!");
                itemList.Add(new LocalData(blocks[i].Position.x.ToString(), blocks[i].Position.y.ToString(), blocks[i].Position.z.ToString(),
                                                                     int.Parse(blocks[i].Info.FurnitureNumber),
                                                                     (int)blocks[i].target.transform.GetComponent<MeshFilter>().mesh.bounds.size.x,
                                                                     (int)blocks[i].target.transform.GetComponent<MeshFilter>().mesh.bounds.size.y,
                                                                     (int)blocks[i].target.transform.GetComponent<MeshFilter>().mesh.bounds.size.z,
                                                                     blocks[i].target.transform.rotation.z.ToString()));
            }
            
            itemJson = JsonMapper.ToJson(itemList);
            ur = userRoomInfo.GetComponent<UserRoomInfo>();

            
            PlayerPrefs.SetString(roomName, itemJson.ToString());
            PlayerPrefs.Save();


            Destroy(userRoomInfo);

            return;
        }


        //StartCoroutine(Send());

        
        string ip = "10.27.18.70";

       
        for (int i = 0; i < blocks.Length; i++)
        {
            info = "http://" + ip + "//~kim/addobject.php?ROOMID=" + rid;
            info = info + "&objectx=" + blocks[i].Position.x.ToString();
            info = info + "&objecty=" + blocks[i].Position.y.ToString();
            info = info + "&objectz=" + blocks[i].Position.z.ToString();
            info = info + "&objectkey=" + blocks[i].Info.FurnitureNumber.ToString();
            info = info + "&objectsizex=" + ((int)blocks[i].Scale.x).ToString();
            info = info + "&objectsizey=" + ((int)blocks[i].Scale.y).ToString();
            info = info + "&objectsizez=" + ((int)blocks[i].Scale.z).ToString();
            info = info + "&objectrotation=" + blocks[i].target.transform.rotation.y.ToString();
            Debug.Log(info);
            StartCoroutine(ObSend());
        }

    }
    IEnumerator ObSend()
    {
        www = new WWW(info);
        yield return www;
    }

    IEnumerator LaSend()
    {
        string ip = "10.27.18.70";

        www = new WWW("http://" + ip + "/~kim/searchlast.php");
        //Debug.Log("안녕123123");
        yield return www;

        JsonData itemdata = JsonMapper.ToObject(www.text);

        // Debug.Log(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["ROOMID"].ToString() + "병수");
            rid = itemdata[i]["ROOMID"].ToString();
            Debug.Log(rid + "rid");
        }
    }
    IEnumerator Send()
    {


        userRoomInfo = GameObject.Find("UserRoomInformation");
        roomInfo = GameObject.Find("RoomInformation");
        createdRoomInfo = GameObject.Find("CreatedRoomInformation");
        if (createdRoomInfo != null)
        {
            //isUR = false;
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            cr = createdRoomInfo.GetComponent<CreatedRoomInfo>();
            addressDoSi = cr.addressDoSi;
            address = cr.address;
            x = cr.x;
            y = cr.y;
            z = cr.z;
           // roomId = cr.roomId;
            password = cr.password;
            //Debug.Log(roomId);
        }
        string ip = "10.27.18.70";

        www = new WWW("http://" + ip + "/~kim/add.php?roomx=" + x + "&roomy= " + y + " &roomz= " + z + " &addressdosi= " + addressDoSi + "&address=" + address + " &password=" + password);
        //Debug.Log("안녕123123");
        yield return www;

        JsonData itemdata = JsonMapper.ToObject(www.text);

       // Debug.Log(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["ROOMID"].ToString() + "병수");
            int.TryParse(itemdata[i]["ROOMID"].ToString(), out cr.roomId);
            
        }
    }
}

