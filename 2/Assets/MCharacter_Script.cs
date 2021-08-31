using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MCharacter_Script : MonoBehaviour
{
    [SerializeField] private GameObject GOES_In;
    [SerializeField] private GameObject GETS_In;

    private Collider2D Collider2D_GOES_In;
    private Collider2D Collider2D_GETS_In;

    public bool D_Change;
    public bool A_Change;

    private GameObject EYES_GOES_IN;
    private GameObject EYES_GETS_IN;

    private float timeToCloseEyes;
    private float timeUntileCloseEyes;

    private AudioSource audioSource_Switch_Character;
    
    private Touch theTouch;

    void Awake()
    {
        D_Change = true;

        A_Change = false;
        GETS_In.SetActive(false);

        timeToCloseEyes = 5f;
        timeUntileCloseEyes = 0f;

        EYES_GOES_IN = GOES_In.transform.GetChild(0).gameObject;
        EYES_GETS_IN = GETS_In.transform.GetChild(0).gameObject;

        Collider2D_GOES_In = GOES_In.GetComponent<Collider2D>();
        Collider2D_GETS_In = GETS_In.GetComponent<Collider2D>();

        audioSource_Switch_Character = GetComponent<AudioSource>();
    }

    void Update()
    {   
        if(A_Change == true)
        {
            Debug.Log(Input.touchCount);
            //if(Input.GetKeyDown(KeyCode.D))
            if(Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);
//              Debug.Log("can change the game character");
                if(theTouch.phase == TouchPhase.Ended && SceneManager.GetSceneByName("Gameplay").isLoaded)
                {
                    audioSource_Switch_Character.Play();

                    A_Change = false;
                    D_Change = true;

                    GETS_In.SetActive(false);
                    GOES_In.SetActive(true);
                }
            }
        }
    
        if(D_Change == true)
        {
            //Debug.Log(EYES_GOES_IN.name);
            //if(Input.GetKeyDown(KeyCode.A))
            if(Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);
                if(theTouch.phase == TouchPhase.Began && SceneManager.GetSceneByName("Gameplay").isLoaded)
                {
                    audioSource_Switch_Character.Play();

                    A_Change = true;
                    D_Change = false;

                    GETS_In.SetActive(true);
                    GOES_In.SetActive(false);
                }
            }
        }

    }

    void FixedUpdate()
    {
        if(D_Change == true)
        {
            if(timeUntileCloseEyes >= timeToCloseEyes)
            {
                timeUntileCloseEyes = 0f;
                EYES_GOES_IN.transform.localScale = new Vector3(1f, 0f, 0f);
            }
            else
            {
                EYES_GOES_IN.transform.localScale = new Vector3(1f, 1f, 0f);
                timeUntileCloseEyes += Time.fixedDeltaTime;
            }
        }
         if(A_Change == true)
        {
            if(timeUntileCloseEyes >= timeToCloseEyes)
            {
                timeUntileCloseEyes = 0f;
                EYES_GETS_IN.transform.localScale = new Vector3(1f, 0f, 0f);
            }
            else
            {
                EYES_GETS_IN.transform.localScale = new Vector3(1f, 1f, 0f);
                timeUntileCloseEyes += Time.fixedDeltaTime;
            }
        }
    }
    /*void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        if(collider.gameObject.tag == "Enemies")
        {
            Debug.Log("yeas");
        }
    }*/
}
