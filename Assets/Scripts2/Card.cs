using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

   
    private CardHandController chc;


    

    // Start is called before the first frame update
    void Start()
    {
        chc =FindObjectOfType<CardHandController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    private void OnMouseDown()
    {
        
        chc.CardBeingDragged = this.gameObject;
        chc.TransitionToState(chc.cardSelected);

    }

    

    void OnMouseDrag()
    {
        //transform.position = GetMNouseWorldPos() + mOffset;

        //chc.TransitionToState(chc.cardDragged);
    }


    private void OnMouseUp()
    {
        //chc.TransitionToState(chc.cardReleased);
    }



}
