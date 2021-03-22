using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordCompare : MonoBehaviour
{
    private GameObject content;
    private GameObject panel;
    private GameObject backButton1;
    private GameObject editButton;
    private GameObject text;
    private GameObject inputField;
    private GameObject backButton2;

    public GameObject information;
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
        panel = GameObject.Find("Canvas").transform.Find("Panel2").gameObject;
        panel.SetActive(true);
        backButton1 = GameObject.Find("Panel2").transform.Find("BackButton").gameObject;
        backButton1.SetActive(true);
        editButton = GameObject.Find("Panel2").transform.Find("EditButton").gameObject;
        editButton.SetActive(true);
        text = GameObject.Find("Panel2").transform.Find("PasswordText").gameObject;
        text.SetActive(true);
        inputField = GameObject.Find("Panel2").transform.Find("InputField").gameObject;
        inputField.SetActive(true);

        editButton.GetComponent<RoomReCreated>().address = information.transform.Find("AddressText").GetComponent<Text>().text;
        editButton.GetComponent<RoomReCreated>().x = information.transform.Find("Value").gameObject.GetComponent<Value>().x;
        editButton.GetComponent<RoomReCreated>().y = information.transform.Find("Value").gameObject.GetComponent<Value>().y;
        editButton.GetComponent<RoomReCreated>().z = information.transform.Find("Value").gameObject.GetComponent<Value>().z;
        editButton.GetComponent<RoomReCreated>().password = gameObject.transform.Find("Password").gameObject.GetComponent<Password>().password;

        backButton2 = GameObject.Find("Back").gameObject;
        backButton2.SetActive(false);
        content = GameObject.Find("Scroll View").gameObject;
        content.SetActive(false);
    }
}
