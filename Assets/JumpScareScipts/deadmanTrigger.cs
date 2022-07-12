using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadmanTrigger : MonoBehaviour
{
    [SerializeField] Animation anim;
    [SerializeField] GameObject hitDrama;

    private void Start()
    {
        hitDrama.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("enemyReact");
            hitDrama.SetActive(true);

        }
        else
        {
            anim.Play("EnemyDeath");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
    }
}
