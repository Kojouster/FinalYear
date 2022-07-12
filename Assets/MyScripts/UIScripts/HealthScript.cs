using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] public Text healthText;
    [SerializeField] GameObject deathPanel;
   
    public SaveScript ss;
    public Animation anim;

    [SerializeField] AudioSource chaseSound;
    [SerializeField] GameObject lastBreath;
    [SerializeField] GameObject fadeOut;
    [SerializeField] Transform player;
    public SavePlayerPos spp;
    public SaveLoadGame slg;
    //[SerializeField] GameObject canvas;
    
    // Start is called before the first frame update
    void Start()
    {
       
        healthText.text = ss.playerHealth + "%";
        deathPanel.SetActive(false);
        lastBreath.SetActive(false);
        fadeOut.SetActive(false);
        //canvas.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ss.healthChanged == true)
        {
            ss.healthChanged = false;
            healthText.text = ss.playerHealth + "%";

        }

        if (ss.playerHealth <=  0f)
        {
            chaseSound.Stop();
         
            //canvas.SetActive(false);
            StartCoroutine(DeathEffect());
            anim["Die"].speed = 0.4f;
            ss.playerHealth = 0;
            anim.Play("Die");
            ss.isDead = true;
            spp.playerPosSave();
           
        }

        
    }

    IEnumerator DeathEffect()
    {
        yield return new WaitForSeconds(1.5f);
        lastBreath.SetActive(true);
        deathPanel.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        fadeOut.SetActive(true);
       
        
       
    }
}
