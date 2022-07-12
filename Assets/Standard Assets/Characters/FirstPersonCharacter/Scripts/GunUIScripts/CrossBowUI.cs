using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossBowUI : MonoBehaviour
{
    [SerializeField] Text bowAmnt;
    public SaveScript ss;
    public PlayerAttacks pa;

 
    // Start is called before the first frame update
    void Start()
    {
     bowAmnt.text = ss.Arr + "";
    }

    // Update is called once per frame
    void Update()
    {
        checkArrow();
    }

    void checkArrow()
    {
      bowAmnt.text = ss.Arr + "";

        if ( Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ss.Arr > 0 )
            {

                ss.Arr -= 1;
             
            
            }
        
        
        }
    
    }
}
