using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    public GET_Fill_COLOR_ get_fill_color_;    
    //public GameObject introBackgroundMusic;
    //private AudioSource audioSource_introBackgroundMusic;

    void Awake()
    {
        // sound of the button clicked

       audioSource = GetComponent<AudioSource>();
    }
    public void StartGame_Shop() // from mainMenu to Shop
    {
        // sound of the button clicked
       // audioSource.Play();

        StartCoroutine(LevelLoading("Shop")); // Gameplay
    }
    public void StartGame() // from Shop to Gameplay
    {
        // sound of the button clicked
        // audioSource.Play();

        StartCoroutine(LevelLoading("Gameplay")); // Gameplay

        get_fill_color_.Start_pos_scale();
    }
    public void Shop() // shop button is DISABLE
    {
        StartCoroutine(ShopLoading("Shop"));
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
    IEnumerator ShopLoading(string levelName)
    {
        audioSource.Play();

        animator.SetTrigger("Gameplay");
        
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelName);

        yield return null;
    }
}
