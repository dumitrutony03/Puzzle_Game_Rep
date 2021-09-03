using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Button_CharacterGetsSkin : MonoBehaviour
{   
    // SCRIPT THAT WILL ALLOW US TO KEEP TRACK OF THE COLOR / SPRITE THAT
    // OUR CHARACTER GETS FROM THE INPUT SCENE AND ALSO, IT KEEPS THE EXACT SAME SPRITE
    // THROUGHT THE REST OF THE GAME
    public SpriteRenderer MCharacter_Sprite_1;
    public SpriteRenderer MCharacter_Sprite_2;

    [HideInInspector]
    public Image image;
    public void ButtonClicked()
    {
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        image = EventSystem.current.currentSelectedGameObject.GetComponent<Image>(); // color of the color panel clicked
        
        MCharacter_Sprite_1.color = image.color;
        MCharacter_Sprite_2.color = image.color;
    
    }

    public void SavePlayer_Color()
    {
        SaveSystem.SavePlayer_SpriteColor(this);
    }

    public void LoadPlayer_SpriteColor()
    {
        PlayerData_SpriteColor data_SpriteColor = SaveSystem.LoadPlayer_SpriteColor();

        MCharacter_Sprite_1.color = data_SpriteColor.MCharacter_Sprite_1_PlayerData.color;
        
        MCharacter_Sprite_2.color = data_SpriteColor.MCharacter_Sprite_1_PlayerData.color;
        
    }
}
