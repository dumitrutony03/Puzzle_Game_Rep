using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// REMOVABLE !!!!!!!!!

public class RedScreen : MonoBehaviour
{
    public void DestroyAfterAnimation()
    {
        Destroy(this.gameObject);
    }
}
