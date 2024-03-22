using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerCardList : MonoBehaviour
{

    public CardList cardList;
    public bool[] playerCards;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadPlayerCardList()
    {

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
