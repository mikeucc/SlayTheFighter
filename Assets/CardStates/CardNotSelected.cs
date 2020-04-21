using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardNotSelected : CardBaseState
{
    public override void EnterState(CardHandController cardHand)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Card No Selected State Entered");
        
        cardHand.idleButton.image.color = Color.green;
        cardHand.dropButton.image.color = Color.white;
    }

   
    public override void OnMouseDown(CardHandController cardHand)
    {
        
    }

    public override void OnMouseDrag(CardHandController cardHand)
    {
        
    }

    public override void OnMouseUp(CardHandController cardHandj)
    {
        
    }

    public override void Update(CardHandController cardHand)
    {
        //throw new System.NotImplementedException();
    }
}
