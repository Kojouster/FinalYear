using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int BatteryNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkAmmo());
    }

    IEnumerator checkAmmo()
    {
        yield return new WaitForSeconds(1);
        if (BatteryNum > ss.BatLeft )
        {

            Destroy(gameObject);
        }
    }
}
