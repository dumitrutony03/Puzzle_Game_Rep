using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MCharacter_Script : MonoBehaviour
{
    public GameObject GOES_In;
    public GameObject GETS_In;

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

    // For the GameOver_Canvas
    private GameObject fgowt;
    private bool wrongCharacterMatching;

    public GameObject puzzleSpawner_active;
    public GameObject musicOfTheGame;
    public GameObject END_musicOfTheGame;
    public GameObject GameOver_Canvas;  
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
    
        wrongCharacterMatching = false;
    }

    void Update()
    {   
        fgowt = GameObject.FindGameObjectWithTag("Enemies");
        if(fgowt != null)
        {
            if(fgowt.GetComponent<PuzzlePiece_Clone_Script>().WrongTouched)
            {
                wrongCharacterMatching = true;
                //Time.timeScale = 0f;
            }
        }
        if(wrongCharacterMatching)
        {
            fgowt = GameObject.FindGameObjectWithTag("Enemies");
            if(fgowt != null)
            {
                Destroy(fgowt);
            }
            puzzleSpawner_active.SetActive(false);
            musicOfTheGame.SetActive(false);

            StartCoroutine(GameOver_Canvas_Appear());

            //GameOver_Canvas.SetActive(true);
        }
        /*if(rewardedAdsButton.AD_SEEN) // rewarder video started
        {
            END_musicOfTheGame.SetActive(false); // end_game music off
        }
        if(rewardedAdsButton.playerCanGetTheReward && !rewardedAdsButton.AD_SEEN)
        {
            wrongCharacterMatching = false;
            rewardedAdsButton.playerCanGetTheReward = false;

            puzzleSpawner_active.SetActive(true);
            musicOfTheGame.SetActive(true);

            GameOver_Canvas.SetActive(false); // ad canvas disappear

        }*/

        if(A_Change == true)
        {
            Debug.Log(Input.touchCount);
            //if(Input.GetKeyDown(KeyCode.D))
            if(Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);
            //Debug.Log("can change the game character");
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
    IEnumerator GameOver_Canvas_Appear()
    {
        yield return new WaitForSeconds(2.8f);

        GameOver_Canvas.SetActive(true);
        wrongCharacterMatching = false;

        yield return new WaitForSeconds(0.5f);
        END_musicOfTheGame.SetActive(true);

    }
}
