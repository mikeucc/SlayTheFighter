using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitilizeHand : MonoBehaviour
{
    //Object is a card
    public GameObject ObjectToSpawn;
    public float cardPositionX;
    public float cardPositionY;
    public float cardSpacer;
    //Angle of Card, Set in Editor
    public Vector3 rotateV;
    // Start is called before the first frame update
    void Start()
    {
        
        //Create 5 Cards
        for (int i = 0; i < 5; i++)
        {
            Vector3 vector3 = new Vector3(cardPositionX,cardPositionY);
            
            ObjectToSpawn.transform.position = vector3;
            //ObjectToSpawn.transform.eulerAngles = rotateV;
            Instantiate(ObjectToSpawn);
            cardPositionX = cardPositionX + cardSpacer;
            //ObjectToSpawn.Card
        }


    }

    
    // Update is called once per frame, Probably not needed
    void Update()
    {
        
    }
}
