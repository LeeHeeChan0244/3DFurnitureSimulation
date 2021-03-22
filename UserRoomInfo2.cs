using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserRoomInfo2 : MonoBehaviour
{
    
    public string roomName;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject userRoomObject2;
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
        DontDestroyOnLoad(userRoomObject2);
        SceneManager.LoadScene("UserDefinedRoomCreator");
    }
}
