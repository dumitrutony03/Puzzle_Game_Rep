using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Text : MonoBehaviour
{
    private Animator animator;

    private Text score_Text;
    public int Score;

    private bool EnemyGreatPositioned;

    private GameObject fgowt;
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
//            Debug.Log("good positioned");
            EnemyGreatPositioned = false;
            animator.SetTrigger("PopUp");
            Score ++;
            CheckScore(Score);
        }
    }
    void CheckScore(int Score)
    {
        if(Score <= 10)
            score_Text.text = Score.ToString() + " / ".ToString() + 10.ToString();
        if(Score >= 10 && Score <= 25)
            score_Text.text = Score.ToString() + " / ".ToString() + 25.ToString();
        if(Score >= 25 && Score <= 50)
            score_Text.text = Score.ToString() + " / ".ToString() + 50.ToString();
        if(Score >= 50 && Score <= 100)
            score_Text.text = Score.ToString() + " / ".ToString() + 100.ToString();
    }
}
