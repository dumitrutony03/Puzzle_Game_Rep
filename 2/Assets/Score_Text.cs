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

    //public coins_Rubys coins_Rubys;

    //public GameObject coins;
   // public GameObject rubys;

    void Start()
    {
        //LoadPlayer();

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
            //Debug.Log("good positioned");
            EnemyGreatPositioned = false;
            animator.SetTrigger("PopUp");

            //coins.GetComponent<Coins_Rubys>().coins ++;
            //coins.GetComponent<Text>().text = coins.GetComponent<Coins_Rubys>().coins.ToString();

            Score ++;
            CheckScore(Score);

            //SavePlayer();

            /*if(Score % 100 == 0 && Score > 0)
            {
                rubys.GetComponent<Coins_Rubys>().rubys ++;
                rubys.GetComponent<Text>().text = rubys.GetComponent<Coins_Rubys>().rubys.ToString();

                //SavePlayer();
            }*/
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

    /*public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        coins.GetComponent<Coins_Rubys>().coins = data.Score_Coins;
        coins.GetComponent<Text>().text = coins.GetComponent<Coins_Rubys>().coins.ToString();

        rubys.GetComponent<Coins_Rubys>().rubys = data.Score_Rubys;
        rubys.GetComponent<Text>().text = rubys.GetComponent<Coins_Rubys>().rubys.ToString();
    }*/
}
