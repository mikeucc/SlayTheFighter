using UnityEngine;

public abstract class CardBaseState 
{
    public abstract void EnterState(CardHandController cardHand);

    public abstract void Update(CardHandController cardHand);

    public abstract void OnMouseDown(CardHandController cardHand);

    public abstract void OnMouseDrag(CardHandController cardHand);

    public abstract void OnMouseUp(CardHandController cardHand);

}
