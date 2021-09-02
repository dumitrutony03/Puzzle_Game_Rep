using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Button_CharacterGetsSkin : MonoBehaviour
{   
    public SpriteRenderer MCharacter_Sprite_1;
    public SpriteRenderer MCharacter_Sprite_2;
    public void ButtonClicked()
    {
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        Image image = EventSystem.current.currentSelectedGameObject.GetComponent<Image>(); // color of the color panel clicked
        
        MCharacter_Sprite_1.color = image.color;
        MCharacter_Sprite_2.color = image.color;
    }

}
