using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [Space(10)]
    [Header("¿¨ÅÆÃû³Æ")]
    public Text nameText;

    [Space(10)]
    [Header("¿¨ÅÆ¹¥»÷Á¦")]
    public Text atkText;

    [Space(10)]
    [Header("¿¨ÅÆµãÊý")]
    public Text pointText;

    [Space(10)]
    [Header("¿¨ÅÆÔªËØÀàÐÍ")]
    public Text elementTypeText;

    [Space(10)]
    [Header("¿¨ÅÆÐ§¹û")]
    public Text effectText;

    [Space(10)]
    [Header("¿¨ÅÆ±³¾°")]
    public Image backGroundImage;

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.cardName;
        pointText.text = card.point.ToString();
        if (card is ElementCard)
        {
            var elementCard = card as ElementCard;
            elementTypeText.text = elementCard.elementType;

            atkText.gameObject.SetActive(false);
            effectText.gameObject.SetActive(false);
        }
        else if (card is WeaponCard)
        {
            var weaponCard = card as WeaponCard;
            atkText.text = weaponCard.atk.ToString();

            effectText.gameObject.SetActive(false);
            elementTypeText.gameObject.SetActive(false);
        }
        else if (card is ActivityCard)
        {
            var activityCard = card as ActivityCard;
            effectText.text = activityCard.effect;

            elementTypeText.gameObject.SetActive(false);
            atkText .gameObject.SetActive(false);
        }
    }
}
