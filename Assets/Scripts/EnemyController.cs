using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float health = 0;
    private Animator animator;
    private EnemyHealth enemyHealth;
    private ParticleSystem system;
    private AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        system = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        enemyHealth = GetComponent<EnemyHealth>();

    }

    public void GotHit()
    {
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(10);
            animator.SetTrigger("GotHit");
            system.Play();
            audioSource.Play();
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(1); // Add 1 point per hit
            }


        }

    }
       
}
