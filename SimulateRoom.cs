using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;


public class SimulateRoom : MonoBehaviour
{
    WWW www;
    int roomId = 0;
    int x = 0, y = 0, z = 0;
    public Text addressDoSi;
    public CreatedRoomInfo cr;
    public InputField password;
    public InputField address;
    public InputField xValue;
    public InputField yValue;
    public InputField zValue;
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
        bool result;
        password.text = password.text.Trim();
        address.text = address.text.Trim();
        xValue.text = xValue.text.Trim();
        yValue.text = yValue.text.Trim();
        zValue.text = zValue.text.Trim();

        if (password.text == "" || address.text == "" || xValue.text == "" || yValue.text == "" || zValue.text == "")
            return;

        result = int.TryParse(xValue.text, out x);
        if (!result)
        {
            xValue.text = "";
            return;
        }

        result = int.TryParse(yValue.text, out y);
        if (!result)
        {
            yValue.text = "";
            return;
        }

        result = int.TryParse(zValue.text, out z);
        if (!result)
        {
            zValue.text = "";
            return;
        }

        StartCoroutine(Send());
 
        cr.password = password.text;
        cr.addressDoSi = addressDoSi.text;
        cr.address = address.text;
        cr.x = x;
        cr.y = y;
        cr.z = z;
        cr.roomId = roomId;

      

        cr.call();
    }

    IEnumerator Send()
    {
        
        
        string ip = "10.27.18.70";

        www = new WWW("http://" + ip + "/~kim/add.php?roomx=" + x + "&roomy= " + y + " &roomz= " + z + " &addressdosi= " + addressDoSi.text + "&address=" + address.text + " &password=" + password.text);
        Debug.Log("안녕1212");
        Debug.Log(www.text);

        yield return www;

        JsonData itemdata = JsonMapper.ToObject(www.text);

        Debug.Log(itemdata.Count);
        Debug.Log(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["ROOMID"].ToString() + "병수");
            int.TryParse(itemdata[i]["ROOMID"].ToString(), out roomId);
        }
    }


}
