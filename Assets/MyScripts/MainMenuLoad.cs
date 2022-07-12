using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveScript ss;
    
    public void Awake()
    {
       
       
        if (ss.isDead == true)
        {
            
            StartCoroutine(delayLoad());
            //ss.isDead = false;
            
        }
        

    }

    IEnumerator delayLoad()
    {
       
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Respawner");
        




    }
}
