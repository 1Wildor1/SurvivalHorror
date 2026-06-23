using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок пойман");

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex);
        }
    }
}