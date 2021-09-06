using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class R_MM_Script : MonoBehaviour, IPointerEnterHandler
{
    public Animator animator_Restart_Button;
    public Animator animator_MainMenu_Button;

    private bool OverRestartButton;
    private bool OverMainMenuButton;

    public AudioSource audioSource;

    void Start()
    {
        animator_Restart_Button = animator_Restart_Button.GetComponent<Animator>();
        animator_MainMenu_Button = animator_MainMenu_Button.GetComponent<Animator>();

        OverRestartButton = false;
        OverMainMenuButton = false;

        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            //StartCoroutine(OverRestartButtonAnimation());
            //StartCoroutine(OverMainMenuButtonAnimation());

            if(eventData.pointerCurrentRaycast.gameObject.name == "Restart")
            {
                OverRestartButton = true;
                audioSource.Play();
            }
            else
            {
                OverRestartButton = false;
            }
            if(eventData.pointerCurrentRaycast.gameObject.name == "MainMenu")
            {
                OverMainMenuButton = true;

                audioSource.Play();
            }
            else
            {
                OverMainMenuButton = false;          
            }
        }
    }
    public void RestartButton()
    {
        StartCoroutine(Play_SFX_RESTART());
    }
    public void MainMenuButton()
    {
        StartCoroutine(Play_SFX_MAINMENU());
    }
    IEnumerator OverRestartButtonAnimation(GameObject gameObject)
    {
        while(!OverRestartButton)
        {
            //animator_Restart_Button.SetBool("MouseOverButton", OverRestartButton);
            yield return null;
        }
        //animator_Restart_Button.SetBool("MouseOverButton", OverRestartButton);

        yield return new WaitForSeconds(0.3f);

        OverRestartButton = false;
        //animator_Restart_Button.SetBool("MouseOverButton", OverRestartButton);
    }
    IEnumerator OverMainMenuButtonAnimation(GameObject gameObject)
    {
        while(!OverMainMenuButton)
        {
            //animator_MainMenu_Button.SetBool("MouseOverButton", OverMainMenuButton);
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            yield return null;
        }
        gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1f);

        yield return new WaitForSeconds(0.3f);

        OverMainMenuButton = false;
        animator_MainMenu_Button.SetBool("MouseOverButton", OverMainMenuButton);
    }
    IEnumerator Play_SFX_RESTART()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("Gameplay");
    }
    IEnumerator Play_SFX_MAINMENU()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("MainMenu");
    }
}
