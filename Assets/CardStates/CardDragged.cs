using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDragged : CardBaseState
{
    public override void EnterState(CardHandController cardHand)
    {
        Debug.Log("Card Dragged State Entered");

        cardHand.dragButton.image.color = Color.green;
        cardHand.selectButton.image.color = Color.yellow;
    }

    
    public override void OnMouseDown(CardHandController cardHand)
    {
       
    }

    

    public override void OnMouseDrag(CardHandController cardHand)
    {
        
        
    }



    public override void OnMouseUp(CardHandController cardHand)
    {
        cardHand.TransitionToState(cardHand.cardReleased);
    }

    public override void Update(CardHandController cardHand)
    {
        
    }

    
}
