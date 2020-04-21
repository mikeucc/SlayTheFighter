using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void CardRemovedFromHand(GameObject selectedCard);

public delegate void CardDraggedToNewLocation(GameObject selectedCard, Vector3 newLocation);

public class CardHandController : MonoBehaviour
{
    public event CardRemovedFromHand CardToRemove;
    

    private CardBaseState currentState;

    public readonly CardNotSelected cardNotSelected = new CardNotSelected();
    public readonly CardDragged cardDragged = new CardDragged();
    public readonly CardSelected cardSelected = new CardSelected();
    public readonly CardReleased cardReleased = new CardReleased();

    public GameObject SpawnCard;
    public GameObject CardBeingDragged;
    public float cardPositionX;
    public float cardPositionY;
    public float cardSpacer;
    
    
    public float speed;
    private Vector3 destination;
    public Button selectButton;
    public Button dragButton;
    public Button dropButton;
    public Button idleButton;

     




    // Start is called before the first frame update
    void Start()
    {
        for (int i = -5; i < 2; i++)
        {
            Vector3 vector3 = new Vector3(cardPositionX+i, cardPositionY);

            SpawnCard.transform.position = vector3;
            //ObjectToSpawn.transform.eulerAngles = rotateV;
            Instantiate(SpawnCard);
            cardPositionX = cardPositionX + cardSpacer;
            //ObjectToSpawn.Card
        }
        Debug.Log("Card Hand Conbtroller class Start Called");

        TransitionToState(cardNotSelected);
 
    }

    // Update is called once per frame
    void Update()
    {

        currentState.Update(this);

        

    }



    private void OnMouseDrag()
    {

        currentState.OnMouseDrag(this);
    }


    private void OnMouseUp()
    {

        currentState.OnMouseUp(this);

        /*mZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = CardBeingDragged.transform.position - GetMNouseWorldPos();
        SetDestination(GetMNouseWorldPos());
        if (CardBeingDragged != null)
        {
            Vector3 mousePoint = Input.mousePosition;
            
            
            Debug.Log("Mouse Up");

            if (Camera.main.ScreenToWorldPoint(mousePoint).y < -3)
            {
                CardToRemove?.Invoke(CardBeingDragged);
            }
            else
            {
                CardDragged?.Invoke(CardBeingDragged, GetMNouseWorldPos());
            }
        }
        */
    }


    

    void IncrementPosition()
    {
        // Calculate the next position
        float delta = speed * Time.deltaTime;
        Vector3 currentPosition = CardBeingDragged.transform.position;
        Vector3 nextPosition = Vector3.MoveTowards(currentPosition, destination, delta);

        // Move the object to the next position
        CardBeingDragged.transform.position = nextPosition;
        //Debug.Log("Increment Position "+CardBeingDragged.transform.position.ToString());
    }

    // Set the destination to cause the object to smoothly glide to the specified location
    public void SetDestination(Vector3 value)
    {
        destination = value;
        Debug.Log("Card being dragged to " + value.ToString());
    }


    public void TransitionToState(CardBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

   


}
