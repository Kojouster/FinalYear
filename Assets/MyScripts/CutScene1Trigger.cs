using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene1Trigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject cutScene1;
    [SerializeField] public SaveScript ss;
    [SerializeField] public Camera cam;
    // Start is called before the first frame update

    private void Start()
    {
        player.SetActive(true);
        cutScene1.SetActive(false);
        cam.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && ss.NewGame == true)
        {
            cutScene1.SetActive(true);
            player.SetActive(false);
            cam.enabled = true;

            StartCoroutine(switchToPlayer());
        
        }

    }

    IEnumerator switchToPlayer()
    {
        yield return new WaitForSeconds(1.71f);
        cutScene1.SetActive(false);
        player.SetActive(true);
        cam.enabled = false;
        Destroy(this.gameObject);
    }
}
