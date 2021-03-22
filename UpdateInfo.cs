using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpdateInfo : MonoBehaviour
{
    public Transform target;
    public InputField length;
    public InputField width;
    public InputField height;
    public bool isUpdated;
    private float lastX,lastY,lastZ;
    // Start is called before the first frame update
    void Start()
    {
        isUpdated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUpdated)
        {
            if (length.text == "" || width.text == "" || height.text == ""|| Convert.ToSingle(length.text) ==  0|| Convert.ToSingle(width.text) == 0 || Convert.ToSingle(height.text) == 0)
            { return; }
            else
            {
                target.localScale = new Vector3((Convert.ToSingle(length.text) * target.localScale.x / lastX),
                                                                            (Convert.ToSingle(width.text) * target.localScale.y / lastY),
                                                                           (Convert.ToSingle(height.text) * target.localScale.z / lastZ));
                lastX = Convert.ToSingle(length.text);
                lastY = Convert.ToSingle(width.text);
                lastZ = Convert.ToSingle(height.text);
                isUpdated = false;
            }
        }
    }

    public void Init()
    {
        lastX = (int)(target.transform.GetComponent<MeshFilter>().mesh.bounds.size.x*100);
        lastZ = (int)(target.transform.GetComponent<MeshFilter>().mesh.bounds.size.z*100);
        lastY = (int)(target.transform.GetComponent<MeshFilter>().mesh.bounds.size.y*100);

        length.text = (lastX).ToString();
        width.text = (lastY).ToString();
        height.text = (lastZ).ToString();

        isUpdated = true;
    }
}
