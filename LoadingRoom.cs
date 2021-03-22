using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class ObjectData
{
    public int ROOMID;
    public int OBJECTID;
    public float objectx;
    public float objecty;
    public float objectz;
    public int objectkey;
    public int objectsizex;
    public int objectsizey;
    public int objectsizez;
    public float objectrotation;
}

public class LocalData
{
    public string objectx;
    public string objecty;
    public string objectz;
    public int objectkey;
    public int objectsizex;
    public int objectsizey;
    public int objectsizez;
    public string objectrotation;

    public LocalData(string a, string b, string c, int d, int e, int f, int g, string h)
    {
        objectx = a;
        objecty = b;
        objectz = c;
        objectkey = d;
        objectsizex = e;
        objectsizey = f;
        objectsizez = g;
        objectrotation = h;
    }
}

public class LoadingRoom : MonoBehaviour
{
    public GameObject floor;
    public GameObject list;
    public GameObject category;
    public GameObject plusImage;
    public GameObject listUI;
    public GameObject locatingUI;
    public GameObject saveButton;
    public GameObject confirmButton;
    public GameObject categoryManage;
    GameObject userRoomInfo;
    GameObject createdRoomInfo;
    GameObject roomInfo;
    RoomInfo ri;
    UserRoomInfo ur;
    CreatedRoomInfo cr;
    public string addressDoSi;
    public string address;
    public int x, y, z;
    public int roomId;
    public string roomName;

    private GameObject target;
    private int start = 0;

    WWW www;
    public bool isDownloaded = false;
    JsonData itemdata = null;

    // Start is called before the first frame update
    public void Start()
    {
        //StartCoroutine(Send());
        userRoomInfo = GameObject.Find("UserRoomInformation");
        roomInfo = GameObject.Find("RoomInformation");
        createdRoomInfo = GameObject.Find("CreatedRoomInformation");
        if (roomInfo != null)
        {
            //Debug.Log("Update1");
            ri = roomInfo.GetComponent<RoomInfo>();
            x = ri.x;
            y = ri.y;
            z = ri.z;
            //address = ri.address;
            //addressDoSi = ri.addressDoSi;
            roomId = ri.roomId;
            Debug.Log("roomid");
        }
        else if (userRoomInfo != null)
        {
            ur = userRoomInfo.GetComponent<UserRoomInfo>();
            x = ur.x;
            y = ur.y;
            z = ur.z;
            roomName = ur.roomName;
            floor.transform.localScale = new Vector3((float)x / 1000, 1, (float)y / 1000);
            Debug.Log(roomName);
            string info = PlayerPrefs.GetString(roomName,null);

            if (info != null)
            {  
                itemdata = JsonMapper.ToObject(info);
                floor.transform.localScale = new Vector3(float.Parse(itemdata[0]["objectx"].ToString()) / 1000, 1, float.Parse(itemdata[0]["objecty"].ToString()) / 1000);
                start = 1;
            }
            else
                return;
        }
        else if (createdRoomInfo != null)
        {
            Debug.Log("Update1");
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            cr = createdRoomInfo.GetComponent<CreatedRoomInfo>();
            x = cr.x;
            y = cr.y;
            z = cr.z;
            roomId = cr.roomId;
        }
        else
        {
            Debug.Log("Update3");
        }

        FurnitureBlock[] blocks = list.GetComponentsInChildren<FurnitureBlock>();
        
        for (int i = start; i < itemdata.Count; i++)
        {
            for (int j = 0; j < blocks.Length; j++)
            {
                if (int.Parse(blocks[j].furnitureData.FurnitureNumber) == int.Parse(itemdata[i]["objectkey"].ToString()))
                {
                    target = blocks[j].LoadFurniture(new Vector3(float.Parse(itemdata[i]["objectx"].ToString()), float.Parse(itemdata[i]["objecty"].ToString()), float.Parse(itemdata[i]["objectz"].ToString())),
                        new Vector3(-90, float.Parse(itemdata[i]["objectrotation"].ToString()),0),
                        new Vector3(float.Parse(itemdata[i]["objectsizex"].ToString())/blocks[j].furnitureData.FurniturePrefab.transform.GetComponent<MeshFilter>().mesh.bounds.size.x,
                                                float.Parse(itemdata[i]["objectsizey"].ToString()) / blocks[j].furnitureData.FurniturePrefab.transform.GetComponent<MeshFilter>().mesh.bounds.size.y,
                                                float.Parse(itemdata[i]["objectsizez"].ToString()) / blocks[j].furnitureData.FurniturePrefab.transform.GetComponent<MeshFilter>().mesh.bounds.size.z));
                }
            }
        }
    }


    IEnumerator Send()
    {
        /*string ip = "192.168.0.13";
        isDownloaded = false;
        www = new WWW("http://" + ip + "/~kim/searchobject.php?ROOMID=" + roomId);


        

        Debug.Log(www.text);

        itemdata = JsonMapper.ToObject(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["OBJECTID"].ToString() + "식별");
            Debug.Log(itemdata[i]["objectx"].ToString());
        }
        Debug.Log(itemdata.Count + "ㅎㅇ");
        
        

        FurnitureBlock[] blocks = list.GetComponentsInChildren<FurnitureBlock>();
        Debug.Log(itemdata.Count);
        for (int i = start; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata.Count);
            for (int j = 0; j < blocks.Length; j++)5555
            {
                Debug.Log(blocks.Length);
                if (int.Parse(blocks[j].furnitureData.FurnitureNumber) == int.Parse(itemdata[i]["objectkey"].ToString()))
                {

                    target = blocks[j].LoadFurniture(new Vector3(int.Parse(itemdata[i]["objectx"].ToString()), int.Parse(itemdata[i]["objecty"].ToString()), int.Parse(itemdata[i]["objectz"].ToString())),
                        new Vector3(-90, float.Parse(itemdata[i]["objectrotation"].ToString()), target.transform.rotation.z),
                        new Vector3(int.Parse(itemdata[i]["objectsizex"].ToString()), int.Parse(itemdata[i]["objecty"].ToString()), int.Parse(itemdata[i]["objectz"].ToString())));
                }
            }
        }*/
        FurnitureBlock[] blocks = list.GetComponentsInChildren<FurnitureBlock>();
        for (int i = 0; i < itemdata.Count; i++)
        {


                    target = blocks[3].LoadFurniture(new Vector3(0,0,0),
                        new Vector3(-90, 0,0),
                        new Vector3(1,1,1));

        }
        yield return www;

    }
}