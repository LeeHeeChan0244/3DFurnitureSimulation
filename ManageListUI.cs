using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageListUI : MonoBehaviour
{
    public GameObject plusButton;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffCategory()
    {
        gameObject.SetActive(false);
    }
}
