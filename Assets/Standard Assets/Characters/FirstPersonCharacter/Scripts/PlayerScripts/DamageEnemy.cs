using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemyHealh = 100;
    private AudioSource player;
    [SerializeField] AudioSource StabSound;
    public bool isDead = false;
    private Animator anim;
    

    [SerializeField] AudioSource ChaseSound;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject BloodSplatterKnife;
    [SerializeField] GameObject BloodSplatterAxe;
    [SerializeField] GameObject BloodSplatterBat;

    [SerializeField] bool isBoss;
    public SimpleShoot1 ss1;
    [SerializeField] GameObject fadeOut;

   
    
    void Start()
    {
        player = GetComponent<AudioSource>();
        anim = GetComponentInParent<Animator>();
        BloodSplatterKnife.SetActive(false);
        BloodSplatterAxe.SetActive(false);
        BloodSplatterBat.SetActive(false);
        ss1.enabled = true;
        fadeOut.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyDeath();
    }

    void enemyDeath()
    {
        if (EnemyHealh <= 0)
        {
           
            if (isDead == false)
            {
                anim.SetTrigger("Death");
                anim.SetBool("SuperDead", true);
                ChaseSound.Stop();
                Destroy(Enemy, 50.0f);
               
                
                isDead = true;
             
            
            }
        }

        if (isBoss == true && EnemyHealh <= 0)
        {

            ss1.enabled = false;
            anim.SetTrigger("bossDead");
            isDead = true;
            ChaseSound.Stop();
            StartCoroutine(loadFinalScene());

           
        }

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pKnife"))
        {
            EnemyHealh -= 10;
            player.Play();
            StabSound.Play();
            BloodSplatterKnife.SetActive(true);
        }

        if (other.gameObject.CompareTag("pAxe"))
        {
            EnemyHealh -= 25;
            player.Play();
            StabSound.Play();
            BloodSplatterAxe.SetActive(true);

        }
        if (other.gameObject.CompareTag("PBat"))
        {
            EnemyHealh -= 15;
            player.Play();
            StabSound.Play();
            BloodSplatterBat.SetActive(true);
        }

        if (other.gameObject.CompareTag("pCrossbow"))
        {
            EnemyHealh -= 50;
            player.Play();
            StabSound.Play();
            Destroy(other.gameObject, 2.0f);
        }
    }

    IEnumerator loadFinalScene()
    {
        yield return new WaitForSeconds(0.7f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene("FinalCutScene");

    }
}
