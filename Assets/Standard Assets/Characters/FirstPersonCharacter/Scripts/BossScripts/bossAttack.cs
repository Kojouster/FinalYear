using UnityEngine;
using UnityEngine.AI;

public class bossAttack : MonoBehaviour
{

   [SerializeField] public NavMeshAgent nav;
    private float distToPlayer;
    [SerializeField] Transform player;
    [SerializeField] GameObject enemy;
    [SerializeField] Animator anim;
    [SerializeField] float AttackRotateSpeed = 2.0f;


    [SerializeField] GameObject chaseSound;
    [SerializeField] GameObject HurtUI;
    [SerializeField] GameObject enemyDamageZone;

    [SerializeField] public SimpleShoot1 ss1;

    private AnimatorStateInfo bossInfo;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponentInParent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        bossHandler();
    }

    // Handling boss movement and anim transitios
    private void bossHandler()
    {
        //Getting a base layer from the animator
        bossInfo = anim.GetCurrentAnimatorStateInfo(0);
        distToPlayer = Vector3.Distance(player.position, enemy.transform.position);
        //if current anim state with a tag chase do the following
        if (bossInfo.IsTag("chase"))
        {
            if (enemyDamageZone.GetComponent<DamageEnemy>().isDead == false)
            {
                chaseSound.SetActive(true);
                nav.isStopped = false;
                nav.acceleration = 24;
                nav.SetDestination(player.position);
                HurtUI.gameObject.SetActive(false);
            }

        }

        if (bossInfo.IsTag("shoot"))
        {
            if (enemyDamageZone.GetComponent<DamageEnemy>().isDead == false)
            {
                nav.isStopped = true;
                nav.acceleration = 180;
                HurtUI.gameObject.SetActive(true);
                // handling enemy rotation while attacking
                Vector3 Pos = (player.position - enemy.transform.position).normalized;
                Quaternion posRot = Quaternion.LookRotation(new Vector3(Pos.x, 0, Pos.z));
                enemy.transform.rotation = Quaternion.Slerp(enemy.transform.rotation, posRot, Time.deltaTime * AttackRotateSpeed);

            }

        }
        if (bossInfo.IsTag("Hurt"))
        {

            ss1.enabled = false;
        
        }

    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.CompareTag("pKnife"))
        {
            anim.SetTrigger("SmallReact");

        }

        if (other.gameObject.CompareTag("pAxe"))
        {
            anim.SetTrigger("SmallReact");

        }

        if (other.gameObject.CompareTag("PBat"))
        {
            anim.SetTrigger("SmallReact");

        }
        if (other.gameObject.CompareTag("pCrossbow"))
        {
            anim.SetTrigger("BigReact");

        }
    }


}
