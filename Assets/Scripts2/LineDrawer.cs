using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineDrawer : MonoBehaviour
{

    private LineRenderer linerend;
    private Vector2 mousePos;
    private Vector2 startMousePos;

    [SerializeField]
    //private Text distanceText;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        linerend = GetComponent<LineRenderer>();
        linerend.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Begin Draw line "+startMousePos.ToString());
        }

        if(Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            linerend.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0f));
            linerend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));
            distance = (mousePos - startMousePos).magnitude;
            //distanceText.text = distance.ToString("F2") + " meters";
            //Debug.Log( distance.ToString());

        
        }

        if(Input.GetMouseButtonUp(0))
        {
            linerend.SetPosition(0, new Vector3(0f, 0f, 0f));
            linerend.SetPosition(1, new Vector3(0f, 0f, 0f));

        }
        
    }
}
