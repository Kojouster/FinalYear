using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMang : MonoBehaviour
{
    [SerializeField] GameObject FadeOut;
    public SaveScript ss;
    // Start is called before the first frame update

    private void Start()
    {
        FadeOut.SetActive(false);
    }
    public void NewGame()
    {
        StartCoroutine(fadein());
        ss.NewGame = true;
      
       
    }

    public void LoadGame()
    {
  
        StartCoroutine(fadein2());
        ss.savedGame = true;
    }

    IEnumerator fadein()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(7);
      
        SceneManager.LoadScene("Loading");


    }

    IEnumerator fadein2()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(7);

        SceneManager.LoadScene("Load");


    }
}
