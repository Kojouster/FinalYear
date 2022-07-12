 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotScript : MonoBehaviour
{
    RaycastHit hit;
    public SaveScript ss;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }


    void ShootGun()
    {
        if (ss.havePistol == true)
        {
            //Player should simultaneously press left and right click to shoot
            if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (ss.pistolBullets > 0)
                {
                    if (Physics.Raycast(transform.position, transform.forward, out hit, 3000))
                    {
                        if (hit.transform.Find("Body"))
                        {
                            //pistol deals random damage from 30 to 101
                            hit.transform.gameObject.GetComponentInChildren<DamageEnemy>().EnemyHealh -= Random.Range(30, 60);
                            hit.transform.gameObject.GetComponent<Animator>().SetTrigger("BigReact");

                        }

                    }
                }
            
            }
        
        }
    
    }
}
