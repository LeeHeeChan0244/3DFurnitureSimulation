using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour
{
    public GameObject listUI;
    public GameObject locatingUI;
    public GameObject block = null;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (block != null)
        {
            block.GetComponent<LocatedListBlock>().Delete();
            listUI.SetActive(true);
            locatingUI.SetActive(false);
        }
    }
}
