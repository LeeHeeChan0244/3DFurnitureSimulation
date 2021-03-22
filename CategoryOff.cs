using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryOff : MonoBehaviour
{
    public GameObject saveButton;
    public GameObject plusButton;
    public GameObject listUI;
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
        saveButton.SetActive(true);
        plusButton.SetActive(true);
        listUI.GetComponent<ManageListUI>().TurnOffCategory();
    }
}
