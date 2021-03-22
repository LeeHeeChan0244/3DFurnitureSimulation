using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomInfo2 : MonoBehaviour
{
    public string password;
    public string addressDoSi;
    public string address;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject RoomObject2;
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
        DontDestroyOnLoad(RoomObject2);
        SceneManager.LoadScene("RoomCreator");
    }
}
