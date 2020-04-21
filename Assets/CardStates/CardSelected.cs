using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelected : CardBaseState
{
    public override void EnterState(CardHandController cardHand)
    {
        Debug.Log("Card Selected State entered");

        cardHand.selectButton.image.color = Color.green;
        cardHand.idleButton.image.color = Color.white;
        cardHand.dropButton.image.color = Color.white;
        cardHand.TransitionToState(cardHand.cardDragged);
    }

    
    public override void OnMouseDown(CardHandController cardHand)
    {
        
    }

    public override void OnMouseDrag(CardHandController cardHand)
    {
        
    }

    public override void OnMouseUp(CardHandController cardHand)
    {
       
    }

    public override void Update(CardHandController cardHand)
    {
        
    }
}
