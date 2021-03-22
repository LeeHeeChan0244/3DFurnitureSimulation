using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rearrange : MonoBehaviour
{
    private GameObject content;
    private GameObject panel;
    private GameObject button1;
    private GameObject button2;
    private GameObject backButton;
    private GameObject inputField;
    private GameObject text;
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
        backButton = GameObject.Find("Canvas").transform.Find("Back").gameObject;
        backButton.SetActive(true);
        content = GameObject.Find("Canvas").transform.Find("Scroll View").gameObject;
        content.SetActive(true);

        button1 = GameObject.Find("BackButton").gameObject;
        button1.SetActive(false);
        button2 = GameObject.Find("EditButton").gameObject;
        button2.SetActive(false);
        inputField = GameObject.Find("InputField").gameObject;
        inputField.SetActive(false);
        text = GameObject.Find("PasswordText").gameObject;
        text.SetActive(false);
        panel = GameObject.Find("Panel2").gameObject;
        panel.SetActive(false);
    }
}
