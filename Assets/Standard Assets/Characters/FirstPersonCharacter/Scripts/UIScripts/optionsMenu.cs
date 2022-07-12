using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class optionsMenu : MonoBehaviour
    {
        [SerializeField] GameObject options;
        public FirstPersonController fpc;
        public PlayerLightSettings pls;
        public SimpleShoot simps;
        public GunShotScript gss;
        public PlayerAttacks pa;

        public GunUIManager gum;
        public CrossBowUI cbu;
        public PickUps pu;
        public CrossbowShoot cs;
        public Inventory inv;
   

        private bool inSettings = false;

        void Start()
        {
            //referencing scripts so I can disable it in the menu
            options.SetActive(false);
            inSettings = false;
            fpc.enabled = true;
            pls.enabled = true;
            simps.enabled = true;
            pa.enabled = true;

            cbu.enabled = true;
            gum.enabled = true;
            pu.enabled = true;
            cs.enabled = true;
            inv.enabled = true;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }

        // Update is called once per frame
        void Update()
        {
            OpenOptionsMenu();
        }


        public void OpenOptionsMenu()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && inSettings == false)
            {
                inSettings = true;
                if (inSettings == true)
                {
                    options.SetActive(true);
                    Time.timeScale = 0;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    fpc.enabled = false; // disabling first person controller script
                    pls.enabled = false; // disabling player light settings
                    simps.enabled = false; //disabling shooting scipts
                    gss.enabled = false;
                    pa.enabled = false;

                    cbu.enabled = false;
                    gum.enabled = false;
                    pu.enabled = false;
                    cs.enabled = false;
                    inv.enabled = false;
                }


            }

            else if (Input.GetKeyDown(KeyCode.Escape) && inSettings == true)
            {
                //When you press esc again cursor does not dissapear,its a uniyu bug , just click with left mouse anywhere on the screen and it will dissapear
                inSettings = false;
                if (inSettings == false)
                {
                    options.SetActive(false);
                    Time.timeScale = 1;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    fpc.enabled = true;
                    pls.enabled = true;
                    simps.enabled = true;
                    gss.enabled = true;
                    pa.enabled = true;

                    cbu.enabled = true;
                    gum.enabled = true;
                    pu.enabled = true;
                    cs.enabled = true;
                    inv.enabled = true;
                }


            }

        }

        public void backToGame()
        {
            inSettings = false;
            if (inSettings == false)
            {
                options.SetActive(false);
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                fpc.enabled = true; //Switching it back on
                pls.enabled = true;
                simps.enabled = true;
                gss.enabled = true;
                pa.enabled = true;

                cbu.enabled = true;
                gum.enabled = true;
                pu.enabled = true;
                cs.enabled = true;
                inv.enabled = true;
            }


        }

    }
}
