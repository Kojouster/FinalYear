using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    [SerializeField] public SaveScript ss;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ss.playerHealth -= 50;
            ss.healthChanged = true;
            Destroy(gameObject);

        }
    }
}
