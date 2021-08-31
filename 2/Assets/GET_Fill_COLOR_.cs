using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GET_Fill_COLOR_ : MonoBehaviour
{
    //public static GET_Fill_COLOR_ instance;

    public GameObject rootGameObject;
    //public SpriteRenderer colorToGetSprite;

    private void Awake()
    {
        //instance = this.game;

        //DontDestroyOnLoad(this.rootGameObject);
    }
    public void Start_pos_scale()
    {
        StartCoroutine(position_scale());
    }
    IEnumerator position_scale()
    {
        DontDestroyOnLoad(this.rootGameObject);

        yield return new WaitForSeconds(0.3f);

        rootGameObject.transform.localScale = new Vector3(1f, 1f, 0.6521739f);
        rootGameObject.transform.position = new Vector3(-11.6f, -2.39f, -0.03614187f); 
    }
}
