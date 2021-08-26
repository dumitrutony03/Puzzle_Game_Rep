using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSpawner_Script : MonoBehaviour
{
    public GameObject[] PuzzlePieces;
    private GameObject PF_PuzzlePiece;
    public GameObject WhereToReach;

    private Vector2 puzzleSpawnerPosition;

    private float WhenToSpawnPuzzlePiece;
    private float timeToSpawnPuzzlePiece;
    private float timeToExpand_WhenToSpawnPuzzlePiece;
    private int timesWhenTimeHasBeenExpanded;

    // Start is called before the first frame update
    void Start()
    {
        puzzleSpawnerPosition = transform.position;

        WhenToSpawnPuzzlePiece = 1.1f;
        timeToSpawnPuzzlePiece = 0f;

        timeToExpand_WhenToSpawnPuzzlePiece = 0f;
        timesWhenTimeHasBeenExpanded = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToExpand_WhenToSpawnPuzzlePiece >= 20f)
        {
            Debug.Log(timesWhenTimeHasBeenExpanded);
            if(timesWhenTimeHasBeenExpanded < 6) // 6 waves
            {
                timesWhenTimeHasBeenExpanded ++;

                timeToExpand_WhenToSpawnPuzzlePiece = 0f;
                WhenToSpawnPuzzlePiece -= 0.095f; // max = -0.58f
            }
        }
        else
        {
            timeToExpand_WhenToSpawnPuzzlePiece += Time.deltaTime;
        }
        if(timeToSpawnPuzzlePiece >= WhenToSpawnPuzzlePiece)
        {
            int randomNumbers = Random.Range(0, 2);

            PF_PuzzlePiece = Instantiate(PuzzlePieces[randomNumbers], puzzleSpawnerPosition, Quaternion.identity);
            PF_PuzzlePiece.GetComponentInChildren<SpriteRenderer>().color = new Color32(((byte)Random.Range(0, 255)), ((byte)Random.Range(0, 255)), ((byte)Random.Range(0, 255)), 255);
            
            timeToSpawnPuzzlePiece = 0f;
        }
        else
        {
            timeToSpawnPuzzlePiece += Time.deltaTime;
        }
    }
}
