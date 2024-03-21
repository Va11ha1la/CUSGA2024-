using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int id;
    public string cardName;
    public int point;
    public string effect;
    public string background;
    public Card(int _id, string _cardName, int _point, string _effect, string _background)
    {
        this.id = _id;
        this.cardName = _cardName;
        this.point = _point;
        this.effect = _effect;
        this.background = _background;
    }
}

public class ElementCard: Card
{
    
    public ElementCard(int _id, string _cardName, int _point, string _effect, string _background):base(_id, _cardName, _point, _effect, _background)
    {
        
    }
}

public class WeaponCard : Card
{
    public int atk;

    public WeaponCard(int _id, string _cardName, int _point, string _effect, string _background, int _atk) : base(_id, _cardName, _point, _effect, _background)
    {
        this.atk = _atk;
    }
}

public class ActivityCard : Card
{
    public ActivityCard(int _id, string _cardName, int _point, string _effect, string _background) : base(_id, _cardName, _point, _effect, _background)
    {

    }
}