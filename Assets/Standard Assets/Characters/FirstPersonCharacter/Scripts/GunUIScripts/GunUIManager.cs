using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunUIManager : MonoBehaviour
{
    [SerializeField] Text bulletAmount;
    public SaveScript ss;
    public PlayerAttacks pa;

 
    // Start is called before the first frame update
    void Start()
    {
        bulletAmount.text = ss.pistolBullets + "";
    }

    // Update is called once per frame
    void Update()
    {
        checkPistolShot();
    }

    void checkPistolShot()
    {
        bulletAmount.text = ss.pistolBullets + "";
        if ( Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ss.pistolBullets > 0 )
            {

                ss.pistolBullets -= 1;
             
            
            }
        
        
        }
    
    }
}
