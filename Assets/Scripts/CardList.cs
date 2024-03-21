using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList : MonoBehaviour
{
    public TextAsset cardData;

    public List<Card> cardList = new List<Card>();
    // Start is called before the first frame update
    void Awake()
    {
        
    }
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
                string effect = rowArray[4];
                string background = rowArray[5];
                ElementCard elementCard = new ElementCard(id, name, point, effect, background);
                cardList.Add(elementCard);

            }
            else if (rowArray[0] == "weapon")
            {
                int id = int.Parse(rowArray[1]);
                string name = rowArray[2];
                int point = int.Parse(rowArray[3]);
                int atk = int.Parse(rowArray[4]);
                string effect = rowArray[5];
                string background = rowArray[6];
                WeaponCard weaponCard = new WeaponCard(id, name, point, effect, background, atk);
                cardList.Add(weaponCard);
            }
            else if (rowArray[0] == "activity")
            {
                int id = int.Parse(rowArray[1]);
                string name = rowArray[2];
                int point = int.Parse(rowArray[3]);
                string effect = rowArray[4];
                string background = rowArray[5];
                ActivityCard activityCard = new ActivityCard(id, name, point, effect, background);
                cardList.Add(activityCard);

            }
        }
    }

    //private void TestLoad()
    //{
    //    foreach (var card in cardList)
    //    {
    //        Debug.Log(card.id.ToString()+ card.cardName);
    //    }
    //}

}
