using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// REMOVABLE !!!!!!!!!

public class RedScreen : MonoBehaviour
{
    public Animator animator;
    public void GameEnded()
    {
        
    }
    /*public GameObject GameOverCanvas;
    public GameObject puzzleEnemiesSpawner;
    public void GameOverCanvas_Panel()
    {
        //Debug.Log("canvas can be alive");
        GameObject canvas = Instantiate(GameOverCanvas, new Vector3(-5.24f, -1.18f, 89.94458f), Quaternion.identity);
        canvas.SetActive(true);
        StartCoroutine(StopGamePlay());
    }
    IEnumerator StopGamePlay()
    {
        puzzleEnemiesSpawner.SetActive(false);
        Time.timeScale = 0f;
        yield return null;
    }*/
}
