using UnityEngine;

public class JumpScareMonster : MonoBehaviour
{
    public float speed = 10f;
    public Transform targetPoint;

    private bool move = false;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        move = true;
        audioSource.Play();
    }

    private void Update()
    {
        if (!move)
            return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPoint.position,
            speed * Time.deltaTime);

        if (Vector3.Distance(transform.position,
                targetPoint.position) < 0.2f)
        {
            Destroy(gameObject);
        }
    }
}