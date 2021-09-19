/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Unity_Monetization : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOsGameId;
    [SerializeField] bool _testMode = false;
    [SerializeField] bool _enablePerPlacementMode = false;
    private string _gameId;
    private bool initialized_ads;

    void Awake() // Awake
    {
        initialized_ads = false;

        StartCoroutine(InitializeAds_Force());
    }
    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOsGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, _enablePerPlacementMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");

        //initialized_ads = true; 

        //Debug.Log(initialized_ads);
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
    IEnumerator InitializeAds_Force()
    {
        Debug.Log("InitializeAds_Force is false " + initialized_ads);
        if(!initialized_ads)    
        {
            InitializeAds();

            OnInitializationComplete();
            //initialized_ads = true;

            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.1f);
        initialized_ads = true;
        Debug.Log("InitializeAds_Force is true " + initialized_ads);
    }
}*/

