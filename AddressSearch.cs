using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class Data
{
    public int ROOMID;
    public int roomx;
    public int roomy;
    public int roomz; 
    public string addressdosi;
    public string address;
    public string password;

    public Data(int id, int x, int y, int z,string addressdosi, string address, string password)
    {
        ROOMID = id;
        roomx = x;
        roomy = y;
        roomz = z;
        addressdosi = addressdosi;
        address = address;
        password = password;
    }
}

public class AddressSearch : MonoBehaviour
{
    GameObject addressInfo;
    AddressInfo ai;

    public string Do;
    public string Si;
    public string addressDoSi;

    public GameObject scrollViewContent;
    public GameObject roomInformationPanel;
    private GameObject panel;
    private GameObject information;
    private GameObject value;
    private GameObject password;
 

    WWW www;
    // Start is called before the first frame update
    void Start()
    {
        /*addressDoSi = "goodJob";
        panel = Instantiate(roomInformationPanel) as GameObject;
        panel.transform.SetParent(scrollViewContent.transform);
        information = panel.transform.Find("Information").gameObject.transform.Find("AddressText").gameObject;
        information.GetComponent<Text>().text = "good1";
        value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
        value.GetComponent<Value>().x = 3;
        value.GetComponent<Value>().y = 2;
        value.GetComponent<Value>().z = 1;
        password = panel.transform.Find("Edit").gameObject.transform.Find("Password").gameObject;
        password.GetComponent<Password>().password = "abc";
        panel = Instantiate(roomInformationPanel) as GameObject;
        panel.transform.SetParent(scrollViewContent.transform);
        information = panel.transform.Find("Information").gameObject.transform.Find("AddressText").gameObject;
        information.GetComponent<Text>().text = "good2";
        value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
        value.GetComponent<Value>().x = 1;
        value.GetComponent<Value>().y = 2;
        value.GetComponent<Value>().z = 3;
        password = panel.transform.Find("Edit").gameObject.transform.Find("Password").gameObject;
        password.GetComponent<Password>().password = "def";*/


        addressInfo = GameObject.Find("AddressInformation");
        ai = addressInfo.GetComponent<AddressInfo>();

        Do = ai.addressDo;
        Si = ai.addressSi;
        addressDoSi = ai.addressDo + ai.addressSi;

        Destroy(addressInfo);

        StartCoroutine(Send());
        //addressPanel.AddComponent<>();
    }

    IEnumerator Send()
    {
        int x, y, z;
        int id;
        string ip = "10.27.18.70";
        www = new WWW("http://" + ip + "/~kim/search.php?do=" + Do + "&si=" + Si);
        yield return www;

        //Debug.Log(www.text);

        JsonData itemdata = JsonMapper.ToObject(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            panel = Instantiate(roomInformationPanel) as GameObject;
            panel.transform.SetParent(scrollViewContent.transform);
            information = panel.transform.Find("Information").gameObject.transform.Find("AddressText").gameObject;
            information.GetComponent<Text>().text =  itemdata[i]["address"].ToString(); //itemdata[i]["addressdosi"].ToString() + " " +
            value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
            int.TryParse(itemdata[i]["ROOMID"].ToString(), out id);
            value.GetComponent<Value>().roomId = id;
            int.TryParse(itemdata[i]["roomx"].ToString(), out x);
            value.GetComponent<Value>().x = x;
            int.TryParse(itemdata[i]["roomy"].ToString(), out y);
            value.GetComponent<Value>().y = y;
            int.TryParse(itemdata[i]["roomz"].ToString(), out z);
            value.GetComponent<Value>().z = z;
            password = panel.transform.Find("Edit").gameObject.transform.Find("Password").gameObject;
            password.GetComponent<Password>().password = itemdata[i]["password"].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
