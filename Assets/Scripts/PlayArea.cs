using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayArea : MonoBehaviour
{
    HorizontalLayoutGroup hlg;
    ClickOn cardToAttach;
    // Start is called before the first frame update
    void Start()
    {
        hlg = this.GetComponent<HorizontalLayoutGroup>();

        Debug.Log("Test");

        foreach(Component c in this.GetComponents<ClickOn>())
        {
            Debug.Log(c.ToString());
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse click over panel");

    }

    private void OnMouseDown()
    {

        Debug.Log("Mouse click over panel");

    }

    private void OnMouseUp()
    {
        
        cardToAttach = this.GetComponent<ClickOn>();

        Debug.Log("Mouse up over panel");

        LayoutRebuilder.ForceRebuildLayoutImmediate(hlg.GetComponent<RectTransform>());
    }

    private void CardToAttach_CardDrop(ClickOn card)
    {
        Debug.Log("Card dropped over play area");
    }
}
