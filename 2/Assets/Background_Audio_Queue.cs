using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Audio_Queue : MonoBehaviour
{
    public GameObject[] audio_Queue;

    private int ct;
    private float time;

    void Start()
    {
        ct = 0;
        time = 0f;

        StartCoroutine(Check_PlaySongs());
    }
    void Update()
    {
        if(time <= 217f) // 231
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0f;
            StartCoroutine(Check_PlaySongs()); 
        }
    }

    IEnumerator PlaySongs()
    {
        audio_Queue[ct].SetActive(true);

        yield return new WaitForSeconds(28f);
        //yield return new WaitForSeconds(5f);
        audio_Queue[ct].SetActive(false);
        ct ++;
        audio_Queue[ct].SetActive(true);


        yield return new WaitForSeconds(41f);
        //yield return new WaitForSeconds(5f);
        audio_Queue[ct].SetActive(false);
        ct ++;
        audio_Queue[ct].SetActive(true);


        yield return new WaitForSeconds(56f);
        //yield return new WaitForSeconds(5f);
        audio_Queue[ct].SetActive(false);
        ct ++;
        audio_Queue[ct].SetActive(true);

        yield return new WaitForSeconds(71f);
        //yield return new WaitForSeconds(5f);
        audio_Queue[ct].SetActive(false);
        ct ++;
        audio_Queue[ct].SetActive(true);

        yield return new WaitForSeconds(21f);
        //yield return new WaitForSeconds(5f);
        audio_Queue[ct].SetActive(false);
        ct = 0;
        audio_Queue[ct].SetActive(true);

        yield return null;
    }
    IEnumerator Check_PlaySongs()
    {
        StartCoroutine(PlaySongs());
        yield return null; // 231
    }
}
