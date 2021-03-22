using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightRotate : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Transform target;
    private bool canRotate;
    // Start is called before the first frame update
    void Start()
    {
        canRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canRotate)
        {
            target.transform.rotation = Quaternion.Euler(target.transform.rotation.eulerAngles.x, target.transform.rotation.eulerAngles.y + 180 * Time.deltaTime , target.transform.rotation.eulerAngles.z);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        canRotate = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        canRotate = false;
    }
}
