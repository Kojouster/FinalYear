using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class churchJumpScare : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animation anim;
    [SerializeField] Animation anim2;
    [SerializeField] Animation anim3;

    [SerializeField] AudioSource furnitureMove;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("churchBench1");
            furnitureMove.Play();
            StartCoroutine(jumpScareDelay());

        }
    }

   
    IEnumerator jumpScareDelay()
    {
        yield return new WaitForSeconds(2.0f);
        anim2.Play("bench2church");
        furnitureMove.Play();
        yield return new WaitForSeconds(2.5f);
        anim3.Play("bench3church");
        furnitureMove.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(this);
    }

    
}
