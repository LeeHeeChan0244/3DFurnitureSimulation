using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserRoomInfo : MonoBehaviour
{
    public string roomName;
    public int x;
    public int y;
    public int z;
    public int mode;
    public GameObject userRoomObject;
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
        DontDestroyOnLoad(userRoomObject);
        SceneManager.LoadScene("RoomSimulator");
    }
}
