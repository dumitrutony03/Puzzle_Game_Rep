using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData_SpriteColor
{
    public MCharacter_Script MCharacter_Script_Character_1;
    public MCharacter_Script MCharacter_Script_Character_2;
    public SpriteRenderer MCharacter_Sprite_1_PlayerData;
    public SpriteRenderer MCharacter_Sprite_2_PlayerData;

    void Awake()
    {
        GameObject childWithSpriteRenderer_1 = MCharacter_Script_Character_1.transform.GetChild (2).gameObject;
        MCharacter_Sprite_1_PlayerData = childWithSpriteRenderer_1.GetComponent<SpriteRenderer>();
    
        GameObject childWithSpriteRenderer_2 = MCharacter_Script_Character_1.transform.GetChild (2).gameObject;
        MCharacter_Sprite_1_PlayerData = childWithSpriteRenderer_2.GetComponent<SpriteRenderer>();
    }

    public PlayerData_SpriteColor(Button_CharacterGetsSkin button_CharacterGetsSkin)
    {
        MCharacter_Sprite_1_PlayerData.color = button_CharacterGetsSkin.MCharacter_Sprite_1.color;//button_CharacterGetsSkin.MCharacter_Sprite_1.color;
        MCharacter_Sprite_2_PlayerData.color = button_CharacterGetsSkin.MCharacter_Sprite_2.color;//button_CharacterGetsSkin.MCharacter_Sprite_2.color;
    }
}
