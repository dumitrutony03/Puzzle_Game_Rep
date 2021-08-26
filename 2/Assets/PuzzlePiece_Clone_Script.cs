using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzlePiece_Clone_Script : MonoBehaviour
{
    public MCharacter_Script mCharacter_Script;
    public Collider2D collider2D_PuzzlePiece;
    public bool WrongTouched;
    public bool ScoreWrongPuzzlePiecePositioned;

    public GameObject Canvas;
    private GameObject CanvasPF;
    private Animator Canvas_PF_Animator;

    public GameObject goodMatchingParticles;
    public GameObject GOOD_Positioned_SFX;
    public GameObject BAD_Positioned_SFX;
    void Awake () {

       mCharacter_Script = GameObject.FindGameObjectWithTag("MCharacter_Spawner").GetComponent<MCharacter_Script>();
    }
    void Start()
    {
        ScoreWrongPuzzlePiecePositioned = false; // we assume it's not good positioned 
        WrongTouched = false;

        // Animation for Canvas
        CanvasPF = Instantiate(Canvas, new Vector2(0f, 0f), Quaternion.identity);
        Canvas_PF_Animator = CanvasPF.GetComponent<Animator>();
    }
    void Update()
    {
        GoLeft();
    }
    private void GoLeft() // Transform PF_PuzzlePiece, Transform WhereToReach
    {
        Vector3 moveDir = new Vector3(-15f, 0f, 0f);
        float moveSpeed = 0.5f;
        //float moveSpeed = 1f; ->> fast
        gameObject.transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D_PuzzlePiece is BoxCollider2D)
        {
            //Debug.Log("box");
            if(mCharacter_Script.D_Change)
            {
                // PARTICLES
                GameObject gMP = Instantiate(goodMatchingParticles, collider2D_PuzzlePiece.transform.position + new Vector3(0f, 1.5f, 0f), Quaternion.identity);
                gMP.SetActive(true);
                Destroy(gMP, 1F);


                // GOOD POSITIONED SFX SOUND
                StartCoroutine(goodSound_SFX());

                ScoreWrongPuzzlePiecePositioned = true; // good positioned

                WrongTouched = false;

                Destroy(gameObject, 0.00001f);

                Destroy(CanvasPF);
            }
            if(mCharacter_Script.A_Change)
            {
                // WRONG POSITIONED
                WrongTouched = true;

                CanvasPF.GetComponent<AudioSource>().Play();

                StartCoroutine(RedScreenAnimationTriggered("GameOver", WrongTouched)); // dead animation and transition to the gameover Scene

                Destroy(gameObject, 0.0001f);
                Destroy(CanvasPF, 3.5f);
                //Destroy(CanvasPF, 0.5f);
            }
            
        }
        if(collider2D_PuzzlePiece is CircleCollider2D)
        {
            //Debug.Log("circle");
            if(mCharacter_Script.A_Change)
            {
                // PARTICLES
                GameObject gMP = Instantiate(goodMatchingParticles, collider2D_PuzzlePiece.transform.position + new Vector3(-1.2f, 1.5f, 0f), Quaternion.identity);
                gMP.SetActive(true);
                Destroy(gMP, 1f);

                // GOOD POSITIONED SFX SOUND
                StartCoroutine(goodSound_SFX());

                ScoreWrongPuzzlePiecePositioned = true; // good positioned

                WrongTouched = false;

                Destroy(gameObject, 0.00001f);

                Destroy(CanvasPF);
            }
            else
            {
                // WRONG POSITIONED

                WrongTouched = true;

                CanvasPF.GetComponent<AudioSource>().Play();

                StartCoroutine(RedScreenAnimationTriggered("GameOver", WrongTouched)); // dead animation and transition to the gameover Scene

                Destroy(gameObject, 0.0001f);
                Destroy(CanvasPF, 3.5f);
                //Destroy(CanvasPF, 0.5f);
            }
        }
    }
    IEnumerator RedScreenAnimationTriggered(string levelName, bool WrongTouched)
    {
        while(!WrongTouched)
        {
            yield return null;        
            //Debug.Log("still fase " + WrongTouched);
        }
        Canvas_PF_Animator.SetTrigger("RedScreen"); // DeadScreen

        yield return new WaitForSeconds(1f);
    }
   IEnumerator goodSound_SFX()
   {
        GameObject gp_SFX = Instantiate(GOOD_Positioned_SFX, transform.position, Quaternion.identity);
        gp_SFX.SetActive(true);

        Destroy(gp_SFX, 2f);
        yield return null;

        //yield return new WaitForSeconds(1f);
        //Destroy(gp_SFX);
   }
}