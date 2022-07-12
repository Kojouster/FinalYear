using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bossShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    
    private bool canShoot = false;
    public SimpleShoot1 ss1;

    void Start()
    {
        ss1.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canShoot = true;
            anim.SetTrigger("aimShoot");
          
           StartCoroutine(ShootPlayer());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canShoot = false;
            StartCoroutine(ShootPlayer());

        }
    }

    IEnumerator ShootPlayer()
    {

        yield return new WaitForSeconds(1f);
        if (canShoot == true)
        {
            ss1.enabled = true;
        }

        if (canShoot == false)
        {
            ss1.enabled = false;
        }
    }
}
