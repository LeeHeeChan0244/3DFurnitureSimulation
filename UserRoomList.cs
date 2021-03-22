using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.IO;

public class UserData
{
    public string roomName;
    public int ROOMID;
    public int roomX;
    public int roomY;
    public int roomZ;

    public UserData(string name, int id, int x, int y, int z)
    {
        roomName = name;
        ROOMID = id;
        roomX = x;
        roomY = y;
        roomZ = z;
    }
}
public class UserRoomList : MonoBehaviour
{
    public GameObject scrollViewContent;
    public GameObject userRoomInformationPanel;
    private GameObject panel;
    private GameObject information;
    private GameObject value;


    WWW www;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        StartCoroutine(Send());
    }

    IEnumerator Send()
    {
        int x, y, z;
        string ip = "10.27.18.70";
        string[] t;
        //www = new WWW("http://" + ip + "/~kim/search.php?do=" + Do + "&si=" + Si); -> 모두 읽어오는 코드로 변경
        yield return www;

        string[] roomList = PlayerPrefs.GetString("roomList").Split(',');
        Debug.Log(PlayerPrefs.GetString("lee"));

        for (int i = 1; i < roomList.Length; i++)
        {
            Debug.Log(roomList[i]);
            panel = Instantiate(userRoomInformationPanel) as GameObject;
            panel.transform.SetParent(scrollViewContent.transform);
            information = panel.transform.Find("Information").gameObject.transform.Find("RoomNameText").gameObject;
            information.GetComponent<Text>().text = roomList[i];
        }
        //Debug.Log(www.text);

        string Path = Application.dataPath + "/Resource";
        Debug.Log(Application.dataPath);


        /*if (System.IO.Directory.Exists(Path))

        {

            //DirectoryInfo 객체 생성

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);

            //해당 폴더에 있는 파일이름을 출력

            foreach (var item in di.GetFiles())

            {
                if (!item.Name.Contains(".meta") && item.Name.Contains(".json"))
                {
                    t = (item.Name).Split('.');
                    panel = Instantiate(userRoomInformationPanel) as GameObject;
                    panel.transform.SetParent(scrollViewContent.transform);
                    information = panel.transform.Find("Information").gameObject.transform.Find("RoomNameText").gameObject;
                    information.GetComponent<Text>().text = t[0];
                }

            }

        }*/
        
            

        

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}