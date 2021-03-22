using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Joystick : MonoBehaviour
{
    public Transform selectedFurniture;
    public Transform Stick;       

    private Vector3 StickFirstPos;  
    private Vector3 JoyVec;
    private Vector3 b = new Vector3(1, 0, -1);
    private float Radius;         
    private bool canMove;

    void Start()
    {
        Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickFirstPos = Stick.transform.position;

        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;
        canMove = false;
    }

    private void Update()
    {
        if (canMove)
        {
            selectedFurniture.transform.Translate(new Vector3(JoyVec.x,0, JoyVec.y) * Time.deltaTime * 2f,Space.World);
        }
    }

    public void Drag(BaseEventData _Data)
    {
        canMove = true;
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;

        JoyVec = (Pos - StickFirstPos).normalized;

        float Dis = Vector3.Distance(Pos, StickFirstPos);

        if (Dis < Radius)
            Stick.position = StickFirstPos + JoyVec * Dis;

        else
            Stick.position = StickFirstPos + JoyVec * Radius;
    }

    public void EndDrag()
    {
        Stick.position = StickFirstPos;
        JoyVec = Vector3.zero;
        canMove = false;
    }
}
