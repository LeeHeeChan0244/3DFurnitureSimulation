using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocatedListBlock : MonoBehaviour
{
    public GameObject locatingUI;
    public GameObject target;
    public GameObject listUI;
    public GameObject delete;
    public GameObject confirm;
    private Vector3 position;
    public Vector3 Position { get { return position; } }
    private Vector3 rotation;
    public Vector3 Rotation { get { return rotation; } }
    private Vector3 scale;
    public Vector3 Scale { get { return scale; } }
    private FurnitureData info;
    public FurnitureData Info { get { return info; } }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setting(FurnitureData data,Vector3 positiondata, Vector3 rotationData, Vector3 scaleData)
    {
        info = data;
        gameObject.transform.Find("Text").GetComponent<Text>().text = info.FurnitureName;
        position = positiondata;
        rotation = rotationData;
        scale = scaleData;
    }

    public void OnClick()
    {
        locatingUI.SetActive(true);
        locatingUI.GetComponent<LocatingManager>().Set(target, position, rotation);
        locatingUI.GetComponent<LocatingManager>().block = gameObject;
        locatingUI.GetComponent<LocatingManager>().target = target;
        delete.SetActive(true);
        delete.GetComponent<DeleteItem>().block = gameObject;
        listUI.SetActive(false);
    }

    public void Delete()
    {
        target.transform.position = new Vector3(1000, 1000, 1000);
        if (target.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Destroy(target);
        }
        Destroy(gameObject);
    }

    public void RealFurnituring(Vector3 positionData, Vector3 scaleData, Vector3 rotationData)
    {
        position = positionData;
        scale = scaleData;
        rotation = rotationData;
    }
}
