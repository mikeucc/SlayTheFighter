using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void CardDroppedIntoArea(ClickOn card);

public class ClickOn : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZcoord;
    private PlayArea dropArea;

    public event CardDroppedIntoArea CardDrop;

    float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    float x;
    float y;
    float z;

    private void Start()
    {
        dropArea = FindObjectOfType<PlayArea>();
    }

    private void OnMouseDown()
    {
        mZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMNouseWorldPos();


    }

    private void OnMouseUp()
    {
        //this.transform.parent = dropArea.transform;
        if(CardDrop!=null)
        {
            CardDrop(this);
        }
        else
        {
            Debug.Log("No subscribers for Card drop event");
        }
        
    }

    private Vector3 GetMNouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZcoord;


        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMNouseWorldPos() + mOffset;       
    }


    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.X)) x = 1 - x;
        if (Input.GetKeyDown(KeyCode.Y)) y = 1 - y;
        if (Input.GetKeyDown(KeyCode.Z)) z = 1 - z;

        //modifying the Vector3, based on input multiplied by speed and time
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;

        //apply the change to the gameObject
        transform.eulerAngles = currentEulerAngles;
    }

}
