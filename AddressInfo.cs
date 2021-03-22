using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddressInfo : MonoBehaviour
{
    public string addressDo;
    public string addressSi;
    public GameObject obj;
    public GameObject addressObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void call()
    {
        DontDestroyOnLoad(addressObject);
        if(obj == GameObject.Find("Search"))
            SceneManager.LoadScene("RoomSearcher");
        else if(obj == GameObject.Find("Register"))
            SceneManager.LoadScene("RoomCreator");
    }
}
