using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applePickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int AppleNum;

    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkApples());

    }

    IEnumerator checkApples()
    {
        yield return new WaitForSeconds(1);
        if (AppleNum > ss.ApplesLeft )   
        {
          
            Destroy(this.gameObject);
        }
    }
}
