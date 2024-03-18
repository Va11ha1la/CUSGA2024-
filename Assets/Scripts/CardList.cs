using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList : MonoBehaviour
{
    public TextAsset cardData;

    public List<Card> cardList = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        LoadCardData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadCardData()
    {
        string[] dataRow = cardData.text.Split('\n');
        foreach (string row in dataRow)
        {
            string[] rowArray = row.Split(',');
            if (rowArray[0] == "#")
            {
                continue;
            }
            else if (rowArray[0] == "element")
            {
                int id = int.Parse(rowArray[1]);
                string name = rowArray[2];
                int point = int.Parse(rowArray[3]);
                string elementType = rowArray[4];
                ElementCard elementCard = new ElementCard(id, name, point, elementType);
                cardList.Add(elementCard);

            }
        }
    }
}
