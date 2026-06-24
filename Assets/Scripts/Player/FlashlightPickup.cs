using UnityEngine;
using TMPro;

public class FlashlightPickup : MonoBehaviour
{
    public Transform flashlightHolder;

    public GameObject pickupText;

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }

    void PickUp()
    {
        pickupText.SetActive(false);

        transform.SetParent(flashlightHolder);

        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;

        FlashlightController flashlight =
            GetComponent<FlashlightController>();

        if (flashlight != null)
            flashlight.canUse = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            pickupText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            pickupText.SetActive(false);
        }
    }
}