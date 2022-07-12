using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinKeyHouseJump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animation anim;
    [SerializeField] Animation animClock;
    [SerializeField] AudioSource furnitureMove;
    [SerializeField] AudioSource hitDark;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(jumpsScareDelay());
        
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(destroyDelay());

        }
    }

    IEnumerator jumpsScareDelay()
    {
        yield return new WaitForSeconds(2.5f);
        anim.Play("cabinChairAnim");
        furnitureMove.Play();
        yield return new WaitForSeconds(5f);
        animClock.Play("clockJumpAnim");
        hitDark.Play();
    }
    IEnumerator destroyDelay()
    {
        yield return new WaitForSeconds(8.5f);
         Destroy(this);
    }
}
