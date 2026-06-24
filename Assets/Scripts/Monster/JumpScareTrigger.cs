using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    public GameObject monster;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (activated)
            return;

        if (other.CompareTag("Player"))
        {
            activated = true;

            monster.SetActive(true);
        }
    }
}