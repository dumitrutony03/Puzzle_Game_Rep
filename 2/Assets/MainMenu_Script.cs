using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public GameObject introBackgroundMusic;
    private AudioSource audioSource_introBackgroundMusic;

    void Awake()
    {
       audioSource = GetComponent<AudioSource>();

       // Background Music
       audioSource_introBackgroundMusic = introBackgroundMusic.GetComponent<AudioSource>();
       audioSource_introBackgroundMusic.Play();
    }
    public void StartGame()
    {
        //audioSource.Play();

        StartCoroutine(LevelLoading("GamePlay"));
    }
    public void QuitGame()
    {   
        audioSource.Play();

        Application.Quit();
    }

    IEnumerator LevelLoading(string levelName)
    {
        audioSource.Play();

        animator.SetTrigger("Gameplay");
        
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelName);

        yield return null;
    }
}
