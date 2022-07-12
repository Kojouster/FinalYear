using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponDamage : MonoBehaviour
{
    [SerializeField] int WeaponDamage = 10;
    [SerializeField] Animator HurtAnim;
    [SerializeField] AudioSource StabSound;
 
    private bool hitActive = false;
    public SaveScript ss;




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hitActive == false)
            {
               
                hitActive = true;
                HurtAnim.SetTrigger("Hurt");
                ss.playerHealth -= WeaponDamage;
                ss.healthChanged = true;
                StabSound.Play();
               
            }
        

        }



    }

   

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hitActive == true)
            {
                hitActive = false;
              

            }


        }



    }
}
