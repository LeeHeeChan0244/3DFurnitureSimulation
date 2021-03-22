using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomInfo : MonoBehaviour
{
    public string addressDoSi;
    public string address;
    public int roomId = 0;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject RoomObject;
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
        DontDestroyOnLoad(RoomObject);
        SceneManager.LoadScene("RoomSimulator");
    }
}
