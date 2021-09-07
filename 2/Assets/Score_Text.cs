using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Text : MonoBehaviour
{
    private Animator animator;

    private Text score_Text;
    public int Score;

    public bool EnemyGreatPositioned;

    private GameObject fgowt;

    public GameObject[] TextPopUp;

    void Start()
    {
        animator = GetComponent<Animator>();

        EnemyGreatPositioned = false;

        score_Text = GetComponent<Text>();
        Score = 0;
    }

    void Update()
    {
        fgowt = GameObject.FindGameObjectWithTag("Enemies");
        if(fgowt != null)
            {
                if(fgowt.GetComponent<PuzzlePiece_Clone_Script>().ScoreWrongPuzzlePiecePositioned)
                {
                    EnemyGreatPositioned = true;
                }
            }
        if(EnemyGreatPositioned)
        {

            if(Score % 5 == 0 && Score != 0)            
                StartCoroutine(Text_PopUp());

            EnemyGreatPositioned = false;   

            Score ++;
        }
    }
    IEnumerator Text_PopUp()
    {
        int rand = Random.Range(0, 5);

        TextPopUp[rand].SetActive(true);
        yield return new WaitForSeconds(1f);
        TextPopUp[rand].SetActive(false);
    }
}
