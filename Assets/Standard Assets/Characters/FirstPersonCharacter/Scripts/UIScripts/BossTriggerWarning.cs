using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class BossTriggerWarning : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] GameObject warningText;
        [SerializeField] GameObject halfFadeIn;

        [SerializeField] GameObject bossWarningTxt;
        [SerializeField] GameObject readyBtn;
        [SerializeField] GameObject notReadyBtn;

        [SerializeField] BoxCollider selfTrigger;
        [SerializeField] public doorScript ds;

        [SerializeField] public BoxCollider door1;
        [SerializeField] public BoxCollider door2;
        [SerializeField] public BoxCollider door3;
        [SerializeField] public BoxCollider door4;

        [SerializeField] public GameObject bossMan;

        public optionsMenu om;
        public Inventory inv;

        void Start()
        {
            warningText.SetActive(false);
            halfFadeIn.SetActive(false);
            bossWarningTxt.SetActive(false);
            readyBtn.SetActive(false);
            notReadyBtn.SetActive(false);
            bossMan.SetActive(false);

            door1.enabled = false;
            door2.enabled = false;
            door3.enabled = false;
            door4.enabled = false;
            selfTrigger.enabled = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                halfFadeIn.SetActive(true);
                StartCoroutine(uiDelay());
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                om.enabled = false;
                inv.enabled = false;

            }
        }
        public void readyButton()
        {

            Time.timeScale = 1;

            door1.enabled = true;
            door2.enabled = true;
            door3.enabled = true;
            door4.enabled = true;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            om.enabled = true;
            inv.enabled = true;
            StartCoroutine(delayDestruction());
            StartCoroutine(delayBossSpawn());

        }
        public void NotReadyButton()
        {

            Time.timeScale = 1;

            door1.enabled = false;
            door2.enabled = false;
            door3.enabled = false;
            door4.enabled = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            om.enabled = true;
            inv.enabled = true;
            bossMan.SetActive(false);
            StartCoroutine(delayDestruction());
            StartCoroutine(renewTrigger());


        }

        IEnumerator uiDelay()
        {
            yield return new WaitForSeconds(1f);
            Time.timeScale = 0;
            bossWarningTxt.SetActive(true);
            readyBtn.SetActive(true);
            notReadyBtn.SetActive(true);
            warningText.SetActive(true);
        }

        IEnumerator delayDestruction()
        {
            yield return new WaitForSeconds(1f);
            selfTrigger.enabled = false;
            warningText.SetActive(false);
            halfFadeIn.SetActive(false);
            bossWarningTxt.SetActive(false);
            readyBtn.SetActive(false);
            notReadyBtn.SetActive(false);
        }

        IEnumerator renewTrigger()
        {
            yield return new WaitForSeconds(15f);
            selfTrigger.enabled = true;

        }

        IEnumerator delayBossSpawn()
        {
            yield return new WaitForSeconds(5.0f);
            bossMan.SetActive(true);
        }
    }
}
