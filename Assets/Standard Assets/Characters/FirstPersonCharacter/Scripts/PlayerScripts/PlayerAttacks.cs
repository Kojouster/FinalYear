using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public SaveScript ss;

   

    public float AttackStamina ;
    [SerializeField] float MaxAttackStamina = 10;
    [SerializeField] float AttackDrain = 2;
    [SerializeField] float AttackRefil = 1;

    [SerializeField] GameObject crosshair;
    private AudioSource myPlayer;
    [SerializeField] AudioClip gunShot;
    [SerializeField] AudioClip crossBowShot;

    public bool isAiming = false;


   
    void Start()
    {
        anim = GetComponent<Animator>();
        AttackStamina = MaxAttackStamina;
        crosshair.SetActive(false);
        myPlayer = GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update()
    {
        WeaponAttacks();
        AimGun();
        AimCrossbow();
      
    }

    void WeaponAttacks()
    {
        Debug.Log(AttackStamina);
        //Attack stamina implied so player can not spam attack button on the enemy
        if (AttackStamina < MaxAttackStamina)
        {
            AttackStamina += AttackRefil * Time.deltaTime;
        }

        if (AttackStamina <= 0.1)
        {
            AttackStamina = 0.1f;

        }

       

        if (AttackStamina > 3.0f)
        {
         
            //Attacking with knife
            if (ss.haveKnife == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("KnifeLmb");
                    AttackStamina -= AttackDrain;
                }

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("KnifeRmb");
                    AttackStamina -= AttackDrain;
                }

            }

            //Attacking with Axe
            if (ss.haveAxe == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("AxeLmb");
                    AttackStamina -= AttackDrain;
                }

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("AxeRmb");
                    AttackStamina -= AttackDrain;
                }

            }
            //Attacking with Bat
            if (ss.haveBat == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("BatLmb");
                    AttackStamina -= AttackDrain;
                }

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("BatRmb");
                    AttackStamina -= AttackDrain;
                }

            }


        }

        
    }

    void AimGun()
    {
        if (ss.havePistol == true)
        {

            if (Input.GetKey(KeyCode.Mouse1) && isAiming == false)
            {
                anim.SetBool("isAiming", true);

                crosshair.SetActive(true);
                isAiming = true;

            }

            if (Input.GetKeyUp(KeyCode.Mouse1) && isAiming == true)
            {
                anim.SetBool("isAiming", false);

                crosshair.SetActive(false);
                isAiming = false;

            }

            if (Input.GetKeyDown(KeyCode.Mouse0) && isAiming == true)
            {
                if (ss.pistolBullets > 0)
                {
                    anim.SetBool("Shoot", true);
                    myPlayer.clip = gunShot;
                    myPlayer.Play();
                }
            }

            if (Input.GetKeyUp(KeyCode.Mouse0) && isAiming == true)
            {
                anim.SetBool("Shoot", false);


            }

            if (Input.GetKeyUp(KeyCode.Mouse0) && isAiming == false)
            {
                if (ss.pistolBullets > 0)
                {
                    myPlayer.clip = gunShot;
                    myPlayer.Play();
                }

            }

            if (Input.GetKeyDown(KeyCode.R) && ss.pistolBullets < 12 && isAiming == false)
            {

               
               


            }
           

        }

        
    }
   
    void AimCrossbow()
    {
        if (ss.haveCrossbow == true)
        {

            if (Input.GetKey(KeyCode.Mouse1) && isAiming == false)
            {
                anim.SetBool("isAiming", true);

                crosshair.SetActive(true);
                isAiming = true;

            }

            if (Input.GetKeyUp(KeyCode.Mouse1) && isAiming == true)
            {
                anim.SetBool("isAiming", false);

                crosshair.SetActive(false);
                isAiming = false;

            }

            if (Input.GetKeyDown(KeyCode.Mouse0) && isAiming == true)
            {
                if (ss.Arr > 0)
                {
                    anim.SetBool("shootCrossbow", true);
                    myPlayer.clip = crossBowShot;
                    myPlayer.Play();
                }
            }

            if (Input.GetKeyUp(KeyCode.Mouse0) && isAiming == true)
            {
                anim.SetBool("shootCrossbow", false);


            }

            if (Input.GetKeyUp(KeyCode.Mouse0) && isAiming == false)
            {
                if (ss.Arr > 0)
                {
                    myPlayer.clip = crossBowShot;
                    myPlayer.Play();
                }

            }



        }

    }

}
