using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDONTDestroy : MonoBehaviour
{
    void Start() 
    {
    
     Destroy(GameObject.Find("ColorChoose_MainCharacter_Controller"));
     
    }
}
