using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class BigEnemyWeaponDamage : MonoBehaviour
    {
        [SerializeField] int WeaponDamage = 10;
        [SerializeField] Animator HurtAnim;
        [SerializeField] AudioSource StabSound;
        [SerializeField] Animator anim;
        private bool hitActive = false;
        public SaveScript ss;
        [SerializeField] GameObject player;
        [SerializeField] GameObject mutant;

        public FirstPersonController fpc;

      

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (hitActive == false)
                {
                    player.transform.parent = mutant.transform;

                    hitActive = true;
                    HurtAnim.SetTrigger("Hurt");
                    ss.playerHealth -= WeaponDamage;
                    ss.healthChanged = true;
                    StabSound.Play();
                    anim.speed = 0.5f;
                    fpc.m_WalkSpeed = 0;
                   

                }
                if (ss.playerHealth == 0)
                {
                    fpc.enabled = false;
                    //player.transform.parent = null;
                
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

    
    
}
