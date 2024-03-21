using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardWareHouse : MonoBehaviour
{

    public GameObject cardPrefab;
    public GameObject cardLayout;

    CardList cardList;
    // Start is called before the first frame update
    void Start()
    {
        
        cardList = GetComponent<CardList>();
        cardList.LoadCardData();
        ShowCardInWareHouse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowCardInWareHouse()
    {
        for(int i = 0; i < cardList.cardList.Count;i++)
        {
            GameObject newCard = GameObject.Instantiate(cardPrefab , cardLayout.transform);
            newCard.GetComponent<CardDisplay>().card = cardList.cardList[i];
            Debug.Log(cardList.cardList[i].cardName);
        }
    }
}
