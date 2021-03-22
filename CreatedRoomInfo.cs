using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatedRoomInfo : MonoBehaviour
{
    public string password;
    public string addressDoSi;
    public string address;
    public int x;
    public int y;
    public int z;
    public int roomId;
    public GameObject createdRoomObject;
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
        DontDestroyOnLoad(createdRoomObject);
        SceneManager.LoadScene("RoomSimulator");
    }
}
