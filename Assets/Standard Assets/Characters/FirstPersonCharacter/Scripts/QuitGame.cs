using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    
    public SavePlayerPos spp;
    [SerializeField] GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        fadeOut.SetActive(false);
    }

    public void Quit()
    {

       
        StartCoroutine(fade());
        spp.playerPosSave();
       
    }

    IEnumerator fade()
    {
        Time.timeScale = 1;
        fadeOut.SetActive(true);
        yield return  new WaitForSeconds(5.3f);
        SceneManager.LoadScene("MainMenu");

    }
}
