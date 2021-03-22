using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    public GameObject saveButton;
    public GameObject category;
    // Start is called before the first frame update

     public void OnClick()
    {
        Debug.Log("오");
        TurnOnCategory();
    }

    public void TurnOnCategory()
    {
        
        saveButton.SetActive(false);
        category.SetActive(true);
        gameObject.SetActive(false);
    }
}
