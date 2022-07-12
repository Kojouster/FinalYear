using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullReload : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject knife;
    [SerializeField] GameObject bat;
    [SerializeField] GameObject axe;
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject crossbow;

    [SerializeField] GameObject Enemy1;
    [SerializeField] GameObject Enemy2;
    [SerializeField] GameObject Enemy3;
    [SerializeField] GameObject Enemy4;
    [SerializeField] GameObject Enemy5;
    [SerializeField] GameObject Enemy6;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(waitToDestroy());
    }

    // Update is called once per frame
   IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(1);
        if (ss.knife == true)
        {
            Destroy(knife.gameObject);
        
        }
        if (ss.bat == true)
        {
            Destroy(bat.gameObject);

        }

        if (ss.axe == true)
        {
            Destroy(axe.gameObject);

        }

        if (ss.pistol == true)
        {
            Destroy(pistol.gameObject);

        }
        if (ss.crossBow == true)
        {
            Destroy(crossbow.gameObject);

        }

        if (ss.Enemy1 == 0)
        {
            Destroy(Enemy1.gameObject);
        
        }

        if (ss.Enemy2 == 0)
        {
            Destroy(Enemy2.gameObject);

        }

        if (ss.Enemy3 == 0)
        {
            Destroy(Enemy3.gameObject);

        }

        if (ss.Enemy4 == 0)
        {
            Destroy(Enemy4.gameObject);

        }

        if (ss.Enemy5 == 0)
        {
            Destroy(Enemy5.gameObject);

        }
        if (ss.Enemy6 == 0)
        {
            Destroy(Enemy6.gameObject);

        }
    }
}
