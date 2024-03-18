using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int id;
    public string cardName;
    public int point;
    public Card(int _id, string _cardName, int _point)
    {
        this.id = _id;
        this.cardName = _cardName;
        this.point = _point;
    }
}

public class ElementCard: Card
{
    public string elementType;

    public ElementCard(int _id, string _cardName, int _point, string _elementType):base(_id, _cardName, _point)
    {
        this.elementType = _elementType;
    }
}

public class WeaponCard : Card
{
    public int atk;

    public WeaponCard(int _id, string _cardName, int _point, int _atk) : base(_id, _cardName, _point)
    {
        this.atk = _atk;
    }
}

public class ActivityCard : Card
{
    public string effect;

    public ActivityCard(int _id, string _cardName, int _point, string effect) : base(_id, _cardName, _point)
    {
        this.effect = effect;
    }
}