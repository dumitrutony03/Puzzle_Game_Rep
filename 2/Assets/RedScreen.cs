using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedScreen : MonoBehaviour
{
    public Animator animator;
    private PuzzlePiece_Clone_Script puzzlePiece_Clone_Script;
    private GameObject fgowt;
    // Start is called before the first frame update
    void Start()
    {
        //fgowt = GameObject.FindGameObjectWithTag("Enemies");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void RedScreenAnimation()
    {
        SceneManager.LoadScene("GameOver");
        //Debug.Log("can load go scene");
    }
}
