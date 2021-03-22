using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialButton : MonoBehaviour
{
    public GameObject panel;
    public GameObject reselectButton;
    public GameObject nextButton;
    public GameObject panel2;
    public GameObject text;
    public GameObject inputField;
    public GameObject backButton;
    public GameObject editButton;
    // Start is called before the first frame update
    void Start()
    {
        reselectButton.SetActive(false);
        nextButton.SetActive(false);
        panel.SetActive(false);
        text.SetActive(false);
        inputField.SetActive(false);
        backButton.SetActive(false);
        editButton.SetActive(false);
        panel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
