using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverCard : MonoBehaviour
{
    public void OnMouseOver()
    {
        //increrase size of card
        //transform.localScale = new Vector3(0.125F, 0.125f, 0);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.1F, 0.1f, 0);
    }

    public void OnMouseDrag()
    {
        transform.localScale = new Vector3(0.125F, 0.125f, 0);
    }

}
