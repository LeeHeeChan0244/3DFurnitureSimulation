using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CategoryManage : MonoBehaviour
{
    public List<FurnitureData> furnitureData;
    public GameObject locatingUI;
    public GameObject prefab;
    public GameObject plusButton;
    public GameObject sampleCategory;
    public GameObject userCategory;
    public GameObject sampleContent;
    public GameObject userContent;
    public GameObject locatedList;
    public GameObject listUI;
    public GameObject spwanPoint;
    public GameObject loader;
    public int initialSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < furnitureData.Count; i++)
        {
            FurnitureBlock block = MakeBlock(i);

            block.transform.SetParent(sampleContent.transform);
            
        }
        userCategory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void SetToSample()
    {
        sampleCategory.SetActive(true);
        userCategory.SetActive(false);
    }
    public void SetToUser()
    {
        userCategory.SetActive(true);
        sampleCategory.SetActive(false);
    }

    public void Selected(GameObject furniture)
    {
        locatingUI.SetActive(true);
        locatingUI.GetComponent<LocatingManager>().Set(furniture,furniture.transform.position,furniture.transform.rotation.eulerAngles);
        listUI.SetActive(false);
    }

    private FurnitureBlock MakeBlock(int num)
    {
        var newFurnifure = Instantiate(prefab).GetComponent<FurnitureBlock>();
        newFurnifure.furnitureData = furnitureData[num];
        newFurnifure.Setting();

        return newFurnifure;
    }
}