using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceRoom : MonoBehaviour
{
    private GameObject content;
    private GameObject panel;
    private GameObject button1;
    private GameObject button2;
    private GameObject backButton;
    public GameObject edit;

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
        panel = GameObject.Find("Canvas").transform.Find("Panel").gameObject;
        panel.SetActive(true);
        button1 = GameObject.Find("Panel").transform.Find("RoomSimulate").gameObject;
        button1.SetActive(true);
        button2 = GameObject.Find("Panel").transform.Find("Reselection").gameObject;
        button2.SetActive(true);

        button1.GetComponent<SimulInfoSend2>().address = gameObject.transform.Find("AddressText").GetComponent<Text>().text;
        button1.GetComponent<SimulInfoSend2>().x = gameObject.transform.Find("Value").gameObject.GetComponent<Value>().x;
        button1.GetComponent<SimulInfoSend2>().y = gameObject.transform.Find("Value").gameObject.GetComponent<Value>().y;
        button1.GetComponent<SimulInfoSend2>().z = gameObject.transform.Find("Value").gameObject.GetComponent<Value>().z;
        button1.GetComponent<SimulInfoSend2>().roomId = gameObject.transform.Find("Value").gameObject.GetComponent<Value>().roomId;

        backButton = GameObject.Find("Back").gameObject;
        backButton.SetActive(false);
        content = GameObject.Find("Scroll View").gameObject;
        content.SetActive(false);
    }
}
