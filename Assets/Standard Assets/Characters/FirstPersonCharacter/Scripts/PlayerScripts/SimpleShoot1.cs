using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Nokobot/Modern Guns/Simple Shoot")]
public class SimpleShoot1 : MonoBehaviour
{
    [Header("Prefab Refrences")]
    public GameObject bulletPrefab;
    [SerializeField] AudioSource gunShoot;
    public GameObject muzzleFlashPrefab;

    [Header("Location Refrences")]

    [SerializeField] private Transform barrelLocation;

    [Header("Settings")]
    [Tooltip("Specify time to destory the casing object")] [SerializeField] private float destroyTimer = 2f;
    [Tooltip("Bullet Speed")] [SerializeField] private float shotPower = 1000f;
   

    private bool isShooting = false;

    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;

       
    }

    void Update()
    {
        if (isShooting == false)
        {
            isShooting = true;
            StartCoroutine(delayShooting());

        }
         
    }


    //This function creates the bullet behavior
    void Shoot()
    {
       
            //Create the muzzle flash
            GameObject tempFlash;
            tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
            Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
          
        //Destroy the muzzle flash effect
               Destroy(tempFlash, destroyTimer);


        //cancels if there's no bullet prefeb
        //if (!bulletPrefab)
        //{ return; }

        //// Create a bullet and add force on it in direction of the barrel


    }

    //This function creates a casing at the ejection slot
    void CasingRelease()
    {
     
        ////Create the casing
        //GameObject tempCasing;
        //tempCasing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        ////Add force on casing to push it out
        //tempCasing.GetComponent<Rigidbody>().AddExplosionForce(Random.Range(ejectPower * 0.7f, ejectPower), (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        ////Add torque to make casing spin in random direction
        //tempCasing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(100f, 1000f)), ForceMode.Impulse);

        ////Destroy casing after X seconds
        //Destroy(tempCasing, destroyTimer);
    }

    IEnumerator delayShooting()
    {
        GetComponent<Animator>().SetTrigger("Fire");
        gunShoot.Play();
        yield return new WaitForSeconds(1f);
  
        isShooting = false;
    }

}
