using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    public AudioSource screamSound;
    [SerializeField] private DontDestroy bgmRoot;
    [SerializeField] private AudioClip currentBGMStageAudioClip;
    [SerializeField] private AudioClip currentBGMStageAudioClipChase;
    [SerializeField] private bool nearToken = false;

    Transform target;
    NavMeshAgent agent;
    Combat combat;
    
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<Combat>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            screamSound.Play();
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {

                PlayerStats targetStats = target.GetComponent<PlayerStats>();
                if (targetStats != null)
                {
                    combat.Attack(targetStats);
                }

                FaceTarget();

                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (distance <= 3 * lookRadius && nearToken == false)
        {
            bgmRoot = GameObject.FindWithTag("BGM").GetComponent<DontDestroy>();
            bgmRoot.ChangeBGM(currentBGMStageAudioClipChase);
            nearToken = true;
        }
        else if (distance > 3 * lookRadius && nearToken == true)
        {
            bgmRoot = GameObject.FindWithTag("BGM").GetComponent<DontDestroy>();
            bgmRoot.ChangeBGM(currentBGMStageAudioClip);
            nearToken = false;
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
