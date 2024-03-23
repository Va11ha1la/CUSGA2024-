using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class PlayerCardList : MonoBehaviour
{

    public TextAsset playerCardData;

    public CardList cardList;
    public bool[] playerCards;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cardList.LoadCardData();
        LoadPlayerCardList();
    }

    void LoadPlayerCardList()
    {
        playerCards = new bool[cardList.cardList.Count];
        string[] dataRow = playerCardData.text.Split('\n');
        foreach (string row in dataRow)
        {
            string[] rowArray = row.Split(',');
            playerCards[int.Parse(rowArray[0])] = Convert.ToBoolean(rowArray[1]);
        }
    }

    void SavePlayerCardList()
    {
        string path = Application.dataPath + "/Datas/PlayerCardList.csv";

        List<string> datas = new List<string>();
        for (int i = 0; i < playerCards.Length; i++)
        {
            datas.Add(i.ToString() + "," + playerCards[i]);
        }

        File.WriteAllLines(path, datas);
    }
}
