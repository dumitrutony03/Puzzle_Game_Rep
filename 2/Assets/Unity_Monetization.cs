using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Unity_Monetization : MonoBehaviour
{
    string AndroidGooglePlay_ID = "4301311";
    bool TestMode = true;

    void Awake()
    {
        Advertisement.Initialize(AndroidGooglePlay_ID, TestMode);
    }
}
