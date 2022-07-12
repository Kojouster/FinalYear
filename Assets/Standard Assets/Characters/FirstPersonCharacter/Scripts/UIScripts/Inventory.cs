using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject InventoryPanel;
    private bool InventoryIsActive = false;

    public SaveScript ss;

    //SFX
  
    [SerializeField] AudioClip gunShot;
    [SerializeField] AudioClip arrowShot;
    // Apples

    [SerializeField] GameObject AppleImg1;
    [SerializeField] GameObject AppleBtn1;

    [SerializeField] GameObject AppleImg2;
    [SerializeField] GameObject AppleBtn2;

    [SerializeField] GameObject AppleImg3;
    [SerializeField] GameObject AppleBtn3;

    [SerializeField] GameObject AppleImg4;
    [SerializeField] GameObject AppleBtn4;

    [SerializeField] GameObject AppleImg5;
    [SerializeField] GameObject AppleBtn5;

    [SerializeField] GameObject AppleImg6;
    [SerializeField] GameObject AppleBtn6;

    //Batteries

    [SerializeField] GameObject batteryImg1;
    [SerializeField] GameObject batteryBtn1;

    [SerializeField] GameObject batteryImg2;
    [SerializeField] GameObject batteryBtn2;

    [SerializeField] GameObject batteryImg3;
    [SerializeField] GameObject batteryBtn3;

    [SerializeField] GameObject batteryImg4;
    [SerializeField] GameObject batteryBtn4;



    //Weapons
    [SerializeField] GameObject knifeIcon;
    [SerializeField] GameObject knifeBtn;

    [SerializeField] GameObject BatIcon;
    [SerializeField] GameObject BatBtn;

    [SerializeField] GameObject axeIcon;
    [SerializeField] GameObject axeBtn;

    [SerializeField] GameObject pistolIcon;
    [SerializeField] GameObject pistolBtn;

    [SerializeField] GameObject crossbowIcon;
    [SerializeField] GameObject crossbowBtn;

    // keys

    [SerializeField] GameObject cabinKeyIcon;
  
    [SerializeField] GameObject houseKeIcon;
   
    [SerializeField] GameObject roomKeyIcon;
 

    //Ammo
    [SerializeField] GameObject AmmoIcon1;
    [SerializeField] GameObject AmmoBtn1;

    [SerializeField] GameObject AmmoIcon2;
    [SerializeField] GameObject AmmoBtn2;

    [SerializeField] GameObject AmmoIcon3;
    [SerializeField] GameObject AmmoBtn3;

    [SerializeField] GameObject AmmoIcon4;
    [SerializeField] GameObject AmmoBtn4;

    //Arrows
    [SerializeField] GameObject ArrowIcon;
    [SerializeField] GameObject ArrowBtn;



    //warning texts

    [SerializeField] GameObject HealthWarningTxt;

    //Sounds
    private AudioSource PlayerAudio;
    [SerializeField] AudioClip appleBite;
    [SerializeField] AudioClip batteryRefil;

    //Arms and equiped weapons
    [SerializeField] GameObject playerArms;
    [SerializeField] GameObject knife;
    [SerializeField] GameObject bat;
    [SerializeField] GameObject axe;

    //Arm equip shhoting weapon

    [SerializeField] GameObject pistol;
    [SerializeField] GameObject crossbow;

    [SerializeField] GameObject GunUI;
    [SerializeField] GameObject CrossbowUI;

    public PlayerAttacks pa;
    //Animator

    public Animator anim;
    void Start() 
    {
        

        InventoryPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked; // locking the cursor at start
        Cursor.visible = false;
        HealthWarningTxt.SetActive(false);
        //Disabling Apples in the inventory
        AppleBtn1.SetActive(false);
        AppleImg1.SetActive(false);

        AppleBtn2.SetActive(false);
        AppleImg2.SetActive(false);

        AppleBtn3.SetActive(false);
        AppleImg3.SetActive(false);

        AppleBtn4.SetActive(false);
        AppleImg4.SetActive(false);

        AppleBtn5.SetActive(false);
        AppleImg5.SetActive(false);

        AppleBtn6.SetActive(false);
        AppleImg6.SetActive(false);


        //Disabling Batteries in the inventory
        batteryImg1.SetActive(false);
        batteryBtn1.SetActive(false);

        batteryImg2.SetActive(false);
        batteryBtn2.SetActive(false);

        batteryImg3.SetActive(false);
        batteryBtn3.SetActive(false);

        batteryImg4.SetActive(false);
        batteryBtn4.SetActive(false);


        // Disabling weapons in the inventory

        knifeIcon.SetActive(false);
        knifeBtn.SetActive(false);

        knifeIcon.SetActive(false);
        knifeBtn.SetActive(false);

        BatIcon.SetActive(false);
        BatBtn.SetActive(false);

        axeIcon.SetActive(false);
        axeBtn.SetActive(false);

        pistolIcon.SetActive(false);
        pistolBtn.SetActive(false);

        crossbowIcon.SetActive(false);
        crossbowBtn.SetActive(false);

        // disabling pistol ammo
        AmmoIcon1.SetActive(false);
        AmmoBtn1.SetActive(false);

        AmmoIcon2.SetActive(false);
        AmmoBtn2.SetActive(false);

        AmmoIcon3.SetActive(false);
        AmmoBtn3.SetActive(false);

        AmmoIcon4.SetActive(false);
        AmmoBtn4.SetActive(false);

        // Disabling keys 
        cabinKeyIcon.SetActive(false);
      

        houseKeIcon.SetActive(false);
       

        roomKeyIcon.SetActive(false);

        //Disabling arrows

        ArrowIcon.SetActive(false);
        ArrowBtn.SetActive(false);

        //Audio
        PlayerAudio = GetComponent<AudioSource>();
        // Weapon UI
        GunUI.SetActive(false);
        CrossbowUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnOnAndOffInventory();
        checkInventory();
        checkWeapons();
        checkForKeys();
        checkPistolAmmo();
        checkArrows();
        equipWeaponsWithButtons();
        reloadWithButton();
    }

    void TurnOnAndOffInventory()
    {

        if (Input.GetKeyDown(KeyCode.I)) // when I is pressed it turns on the Inventory
        {
            if (InventoryIsActive == false)
            {
                InventoryPanel.SetActive(true);
                InventoryIsActive = true;
                Time.timeScale = 0.4f;
                // making cursor visible
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                // so animation does not play in the inventory
                ss.haveKnife = false;
                ss.haveAxe = false;
                ss.haveBat = false;
                ss.havePistol = false;
                ss.haveCrossbow = false;
                


            }

            else if (InventoryIsActive == true )

            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                InventoryPanel.SetActive(false);
                InventoryIsActive = false;
                Time.timeScale = 1.0f;
                
               

            }

           
        
        
        }

      




    }

    void checkInventory() // check if saveScript has these objects
    {
        //Check for Apples

        if (ss.Apples == 0)
        {
            AppleBtn1.SetActive(false);
            AppleImg1.SetActive(false);

            AppleBtn2.SetActive(false);
            AppleImg2.SetActive(false);

            AppleBtn3.SetActive(false);
            AppleImg3.SetActive(false);

            AppleBtn4.SetActive(false);
            AppleImg4.SetActive(false);

            AppleBtn5.SetActive(false);
            AppleImg5.SetActive(false);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }


        if (ss.Apples == 1)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(false);
            AppleImg2.SetActive(false);

            AppleBtn3.SetActive(false);
            AppleImg3.SetActive(false);

            AppleBtn4.SetActive(false);
            AppleImg4.SetActive(false);

            AppleBtn5.SetActive(false);
            AppleImg5.SetActive(false);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }
        if (ss.Apples == 2)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(true);
            AppleImg2.SetActive(true);

            AppleBtn3.SetActive(false);
            AppleImg3.SetActive(false);

            AppleBtn4.SetActive(false);
            AppleImg4.SetActive(false);

            AppleBtn5.SetActive(false);
            AppleImg5.SetActive(false);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }
        if (ss.Apples == 3)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(true);
            AppleImg2.SetActive(true);

            AppleBtn3.SetActive(true);
            AppleImg3.SetActive(true);

            AppleBtn4.SetActive(false);
            AppleImg4.SetActive(false);

            AppleBtn5.SetActive(false);
            AppleImg5.SetActive(false);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }
        if (ss.Apples == 4)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(true);
            AppleImg2.SetActive(true);

            AppleBtn3.SetActive(true);
            AppleImg3.SetActive(true);

            AppleBtn4.SetActive(true);
            AppleImg4.SetActive(true);

            AppleBtn5.SetActive(false);
            AppleImg5.SetActive(false);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }
        if (ss.Apples == 5)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(true);
            AppleImg2.SetActive(true);

            AppleBtn3.SetActive(true);
            AppleImg3.SetActive(true);

            AppleBtn4.SetActive(true);
            AppleImg4.SetActive(true);

            AppleBtn5.SetActive(true);
            AppleImg5.SetActive(true);

            AppleBtn6.SetActive(false);
            AppleImg6.SetActive(false);

        }
        if (ss.Apples == 6)
        {
            AppleBtn1.SetActive(true);
            AppleImg1.SetActive(true);

            AppleBtn2.SetActive(true);
            AppleImg2.SetActive(true);

            AppleBtn3.SetActive(true);
            AppleImg3.SetActive(true);

            AppleBtn4.SetActive(true);
            AppleImg4.SetActive(true);

            AppleBtn5.SetActive(true);
            AppleImg5.SetActive(true);

            AppleBtn6.SetActive(true);
            AppleImg6.SetActive(true);

        }
        //check for batteries


        if (ss.Batteries == 0)
        {
            batteryBtn1.SetActive(false);
            batteryImg1.SetActive(false);

            batteryBtn2.SetActive(false);
            batteryImg2.SetActive(false);

            batteryBtn3.SetActive(false);
            batteryImg3.SetActive(false);

            batteryBtn4.SetActive(false);
            batteryImg4.SetActive(false);

        }
        if (ss.Batteries == 1)
        {
            batteryBtn1.SetActive(true);
            batteryImg1.SetActive(true);

            batteryBtn2.SetActive(false);
            batteryImg2.SetActive(false);

            batteryBtn3.SetActive(false);
            batteryImg3.SetActive(false);

            batteryBtn4.SetActive(false);
            batteryImg4.SetActive(false);

        }

        if (ss.Batteries == 2)
        {
            batteryBtn1.SetActive(true);
            batteryImg1.SetActive(true);

            batteryBtn2.SetActive(true);
            batteryImg2.SetActive(true);

            batteryBtn3.SetActive(false);
            batteryImg3.SetActive(false);

            batteryBtn4.SetActive(false);
            batteryImg4.SetActive(false);

        }

        if (ss.Batteries == 3)
        {
            batteryBtn1.SetActive(true);
            batteryImg1.SetActive(true);

            batteryBtn2.SetActive(true);
            batteryImg2.SetActive(true);

            batteryBtn3.SetActive(true);
            batteryImg3.SetActive(true);

            batteryBtn4.SetActive(false);
            batteryImg4.SetActive(false);

        }

        if (ss.Batteries == 4)
        {
            batteryBtn1.SetActive(true);
            batteryImg1.SetActive(true);

            batteryBtn2.SetActive(true);
            batteryImg2.SetActive(true);

            batteryBtn3.SetActive(true);
            batteryImg3.SetActive(true);

            batteryBtn4.SetActive(true);
            batteryImg4.SetActive(true);

        }

    }

    // checking if player equiped the weapon
    void checkWeapons()
    {
        if (ss.knife == true)
        {
            knifeIcon.SetActive(true);
            knifeBtn.SetActive(true);
        
        }

        if (ss.axe == true)
        {
            axeIcon.SetActive(true);
            axeBtn.SetActive(true);

        }

        if (ss.bat == true)
        {
            BatIcon.SetActive(true);
            BatBtn.SetActive(true);

        }

        if (ss.pistol == true)
        {
            pistolIcon.SetActive(true);
            pistolBtn.SetActive(true);

        }

        if (ss.crossBow == true)
        {
            crossbowIcon.SetActive(true);
            crossbowBtn.SetActive(true);

        }

    }

    void checkForKeys()
    {
        if (ss.cabinKey == true)
        {
            cabinKeyIcon.SetActive(true);
               
        }

        if (ss.roomKey == true)
        {
            roomKeyIcon.SetActive(true);
           

        }
        if (ss.houseKey == true)
        {
            houseKeIcon.SetActive(true);
           
        }
    
    }
    //Arrow check
    void checkArrows()
    {

        
        if (ss.ArrowRefil == false)
        {
            ArrowIcon.SetActive(false);
            ArrowBtn.SetActive(false);

        }
        if (ss.ArrowRefil == true)
        {
            ArrowIcon.SetActive(true);
            ArrowBtn.SetActive(true);
        
        }
    
    }
    //Pistol check
   public void checkPistolAmmo()
    {
        if (ss.PistolAmmo == 0)
        {
            AmmoIcon1.SetActive(false);
            AmmoBtn1.SetActive(false);

            AmmoIcon2.SetActive(false);
            AmmoBtn2.SetActive(false);

            AmmoIcon3.SetActive(false);
            AmmoBtn3.SetActive(false);

            AmmoIcon4.SetActive(false);
            AmmoBtn4.SetActive(false);

        }

        if (ss.PistolAmmo == 1)
        {
            AmmoIcon1.SetActive(true);
            AmmoBtn1.SetActive(true);

            AmmoIcon2.SetActive(false);
            AmmoBtn2.SetActive(false);

            AmmoIcon3.SetActive(false);
            AmmoBtn3.SetActive(false);

            AmmoIcon4.SetActive(false);
            AmmoBtn4.SetActive(false);
         


        }
        if (ss.PistolAmmo == 2)
        {
            AmmoIcon1.SetActive(true);
            AmmoBtn1.SetActive(true);

            AmmoIcon2.SetActive(true);
            AmmoBtn2.SetActive(true);

            AmmoIcon3.SetActive(false);
            AmmoBtn3.SetActive(false);

            AmmoIcon4.SetActive(false);
            AmmoBtn4.SetActive(false);
         

        }
        if (ss.PistolAmmo == 3)
        {
            AmmoIcon1.SetActive(true);
            AmmoBtn1.SetActive(true);

            AmmoIcon2.SetActive(true);
            AmmoBtn2.SetActive(true);

            AmmoIcon3.SetActive(true);
            AmmoBtn3.SetActive(true);

            AmmoIcon4.SetActive(false);
            AmmoBtn4.SetActive(false);
            

        }
        if (ss.PistolAmmo == 4)
        {
            AmmoIcon1.SetActive(true);
            AmmoBtn1.SetActive(true);

            AmmoIcon2.SetActive(true);
            AmmoBtn2.SetActive(true);

            AmmoIcon3.SetActive(true);
            AmmoBtn3.SetActive(true);

            AmmoIcon4.SetActive(true);
            AmmoBtn4.SetActive(true);
           

        }

    }

   public void EatAnApple1() // when player clicks an appple icon in the inventory it adds 10 health and removes image from the inventory
    {
       
        if (ss.playerHealth < 100)
        {
           
            ss.playerHealth += 10;
            ss.healthChanged = true;
            ss.Apples -= 1;
            PlayerAudio.clip = appleBite;
            PlayerAudio.Play();

            if (ss.playerHealth > 100)
            {

                ss.playerHealth = 100;
            
            }
        }

        else
        {
            ss.healthChanged = false;
            StartCoroutine(healthWarning()); // so player can seee that he has low health
        }
       

    }

    public void useTheBattery1()
    {

        ss.BatteryRefil = true;
        ss.BatteryPower = 1;
        ss.Batteries -= 1;

        PlayerAudio.clip = batteryRefil;
        PlayerAudio.Play();

    


    }

    IEnumerator healthWarning()
    {
        HealthWarningTxt.SetActive(true);
        yield return new WaitForSeconds(1);// waiting for one second
        HealthWarningTxt.SetActive(false);
       


    }

   
    // Making weapons equiped in the world 
    public void EquipKnife()
    {
        
            playerArms.SetActive(true);
            knife.SetActive(true);
            axe.SetActive(false);
            bat.SetActive(false);

            crossbow.SetActive(false);
            pistol.SetActive(false);
            anim.SetBool("Meele", true);
            GunUI.SetActive(false);
            CrossbowUI.SetActive(false);

            ss.haveKnife = true;
            ss.haveBat = false;
            ss.haveAxe = false;
            ss.havePistol = false;
            ss.haveCrossbow = false;

    }

   public void EquipAxe()
    {

        playerArms.SetActive(true);
        axe.SetActive(true);
        knife.SetActive(false);
        bat.SetActive(false);

        crossbow.SetActive(false);
        pistol.SetActive(false);
        anim.SetBool("Meele", true);
        GunUI.SetActive(false);
        CrossbowUI.SetActive(false);

        ss.haveKnife = false;
        ss.haveBat = false;
        ss.haveAxe = true;

        ss.havePistol = false;
        ss.haveCrossbow = false;
    }


   public void EquipBat()
    {

        playerArms.SetActive(true);
        bat.SetActive(true);
        knife.SetActive(false);
        axe.SetActive(false);
        GunUI.SetActive(false);
        CrossbowUI.SetActive(false);

        crossbow.SetActive(false);
        pistol.SetActive(false);
        anim.SetBool("Meele", true);

        ss.haveKnife = false;
        ss.haveBat = true;
        ss.haveAxe = false;

        ss.havePistol = false;
        ss.haveCrossbow = false;
    }

    public void EquipPistol()
    {
        playerArms.SetActive(true);
        pistol.SetActive(true);
        bat.SetActive(false);
        knife.SetActive(false);
        axe.SetActive(false);
        crossbow.SetActive(false);
        GunUI.SetActive(true);
        CrossbowUI.SetActive(false);

        PlayerAudio.clip = gunShot;
        PlayerAudio.Play();

        anim.SetBool("Meele", false);
        ss.havePistol = true;

        ss.haveKnife = false;
        ss.haveBat = false;
        ss.haveAxe = false;
        ss.haveCrossbow = false;

    }

    public void EquipCrossbow()
    {
        playerArms.SetActive(true);
        crossbow.SetActive(true);
        pistol.SetActive(false);
        bat.SetActive(false);
        knife.SetActive(false);
        axe.SetActive(false);
        GunUI.SetActive(false);
        CrossbowUI.SetActive(true);

        PlayerAudio.clip = arrowShot;
        PlayerAudio.Play();

        anim.SetBool("Meele", false);

        ss.havePistol = false;

        ss.haveKnife = false;
        ss.haveBat = false;
        ss.haveAxe = false;

        ss.haveCrossbow = true;

    }


    void equipWeaponsWithButtons()
    {

        if (ss.knife == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                EquipKnife();

            }
        }

        if (ss.axe == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                EquipAxe();

            }
        }

        if (ss.bat == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                EquipBat();

            }
        }


        if (ss.pistol == true)
        {
          
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                EquipPistol();

            }
        }

     


        if (ss.crossBow == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                EquipCrossbow();

            }
        }

    }

    public void PistolRefil()
    {
        ss.PistolAmmo -= 1;
        ss.pistolBullets += 12;

        if (ss.pistolBullets > 12)
        {
            ss.pistolBullets = 12;
        }

    }

    public void Bowrefil()
    {
        ss.ArrowRefil = false;
        ss.Arr += 6;

        if (ss.Arr > 6)
        {
            ss.Arr = 6;
         
        }
    
    }

   public void reloadWithButton()
    {
        // reloading weapons when pressing R button
        if (ss.PistolAmmo > 0 && ss.PistolAmmo <= 4)
        {
            if (Input.GetKeyDown(KeyCode.R) && ss.havePistol == true)
            {
                PistolRefil();
                anim.SetBool("isReloading", true);
                StartCoroutine(delayReloadGun());
             

            }
        
        }

        if (ss.ArrowRefil == true)
        {

            if (Input.GetKeyDown(KeyCode.R) && ss.haveCrossbow == true)
            {
                Bowrefil();
                anim.SetBool("isReloadingCross", true);
                StartCoroutine(delayReloadCrossbow());

            }


        }


   }

    IEnumerator delayReloadGun()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isReloading", false);
    }
    IEnumerator delayReloadCrossbow()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isReloadingCross", false);
    }

}
