using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReleased : CardBaseState
{
    public Vector3 destination;
    private readonly float speed = 40;
    private float mZcoord;
    public Vector3 mOffset;

    public override void EnterState(CardHandController cardHand)
    {
        Debug.Log("Card Released State entered");
        cardHand.dragButton.image.color = Color.white;
        cardHand.selectButton.image.color = Color.white;
        cardHand.dropButton.image.color = Color.yellow;

        mZcoord = Camera.main.WorldToScreenPoint(cardHand.CardBeingDragged.gameObject.transform.position).z;
        mOffset = cardHand.CardBeingDragged.transform.position - GetMNouseWorldPos();
        SetDestination(GetMNouseWorldPos());
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
        if (destination != cardHand.CardBeingDragged.transform.position && destination != null)
        {
            // Move towards the destination each frame until the object reaches it
            IncrementPosition(cardHand);
        }
        else
            cardHand.TransitionToState(cardHand.cardNotSelected);
    }

    void IncrementPosition(CardHandController cardHand)
    {
        // Calculate the next position
        float delta = speed * Time.deltaTime;
        Vector3 currentPosition = cardHand.CardBeingDragged.transform.position;
        Vector3 nextPosition = Vector3.MoveTowards(currentPosition, destination, delta);

        // Move the object to the next position
        cardHand.CardBeingDragged.transform.position = nextPosition;
        //Debug.Log("Increment Position "+CardBeingDragged.transform.position.ToString());
    }

    // Set the destination to cause the object to smoothly glide to the specified location
    public void SetDestination(Vector3 value)
    {
        destination = value;
        Debug.Log("Card being dragged to " + value.ToString());
    }

    private Vector3 GetMNouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZcoord;


        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
