using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSceneController : MonoBehaviour
{
    public CardHandController CardHandController;
    // Start is called before the first frame update
    void Start()
    {
        CardHandController = FindObjectOfType<CardHandController>();
        CardHandController.CardToRemove += CardHandController_CardToRemove;
        
    }

    private void CardHandController_CardDragged(GameObject selectedCard, Vector3 newLocation)
    {
        //selectedCard.transform.position = newLocation;
        
    }

    private void CardHandController_CardToRemove(GameObject card)
    {
        
        Destroy(card);
        Debug.Log("Card Event destroy event");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}