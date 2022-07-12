using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatterOnOff : MonoBehaviour
{
    [SerializeField] GameObject bloodOff;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BloodOff());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(BloodOff());
    }

    IEnumerator BloodOff()
    {

        yield return new WaitForSeconds(0.2f);
        bloodOff.SetActive(false);
    
    }
}
