using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    void Awake()
    {
        // sound of the button clicked

       audioSource = GetComponent<AudioSource>();
    }
    public void StartGame_() // from mainMenu to Shop
    {
        StartCoroutine(LevelLoading("Gameplay")); // Gameplay
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
