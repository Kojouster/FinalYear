using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BatteryPower : MonoBehaviour
{
    [SerializeField] Image batteryUI;
    [SerializeField] float drainTime = 20.0f;
    [SerializeField] float power;

    public SaveScript ss;
    
    // Update is called once per frame
    void Update()
    {

        ManagingPower();
    }

    void ManagingPower()
    {
        if (ss.BatteryRefil == true) // when buttery is in inventory set it back to false and fully refil the battery
        {
            batteryUI.fillAmount = 1.0f;
            ss.BatteryRefil = false;
           
        
        }
        // reduces energy when flash ligh and nigh vis is on
        if (ss.NightVisOn == true || ss.FlashLightOn == true)
        {
            // reducing the fill amount by drain time, drain time determines how long it takes to drain the battery ui
            batteryUI.fillAmount -= 1.0f / drainTime * Time.deltaTime;
            power = batteryUI.fillAmount;
            ss.BatteryPower = power;
        }
    }
}
