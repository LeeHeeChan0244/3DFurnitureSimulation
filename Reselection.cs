using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reselection : MonoBehaviour
{
    private GameObject content;
    private GameObject panel;
    private GameObject button1;
    private GameObject button2;
    private GameObject backButton;
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

        button1 = GameObject.Find("RoomSimulate").gameObject;
        button1.SetActive(false);
        button2 = GameObject.Find("Reselection").gameObject;
        button2.SetActive(false);
        panel = GameObject.Find("Panel").gameObject;
        panel.SetActive(false);
    }
}
