using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialButton2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject reselectButton;
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
        reselectButton.SetActive(false);
        nextButton.SetActive(false);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
