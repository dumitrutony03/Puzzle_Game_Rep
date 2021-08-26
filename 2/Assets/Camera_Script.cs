using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public Animator animator;
    private GameObject fgowt;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        fgowt = GameObject.FindGameObjectWithTag("Enemies");
        if(fgowt != null)
            {
                //Debug.Log(fgowt.GetComponent<PuzzlePiece_Clone_Script>().WrongTouched);
                if(fgowt.GetComponent<PuzzlePiece_Clone_Script>().WrongTouched)
                {
                    animator.SetTrigger("WPPositioned");
                }
            }
    }
}
