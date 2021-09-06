using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GET_Fill_COLOR_ : MonoBehaviour
{   
    // USED IN ORDER TO NOT DESTROY THE OBJECT THROUGHT SCENES TRANSITIONS
    // AND ALSO KEEP IT'S APROXIMATE COORDONATE IN THE GAMEPLAY SCENE
    // IN ORDER TO BE VISIBLE ON MOST PART OF THE PHONES

    /*public GameObject rootGameObject;

    public Button_CharacterGetsSkin button_CharacterGetsSkin;

    public void Start_pos_scale()
    {
        StartCoroutine(position_scale());
    }
    IEnumerator position_scale()
    {
        DontDestroyOnLoad(this.rootGameObject);
        button_CharacterGetsSkin.SavePlayer_Color();

        yield return new WaitForSeconds(1.05f); // 0.3f

        rootGameObject.transform.localScale = new Vector3(1f, 1f, 0.6521739f);
        rootGameObject.transform.position = new Vector3(-11.6f, -2.39f, -0.03614187f); 
    }*/
}
