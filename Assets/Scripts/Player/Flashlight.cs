using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light flashlight;

    void Start()
    {
        Debug.Log("Flashlight Start");

        flashlight = GetComponentInChildren<Light>();

        Debug.Log(flashlight);
    }

    void Update()
    {
        Debug.Log("Update работает");

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("press f");

            if (flashlight != null)
                flashlight.enabled = !flashlight.enabled;
        }
    }
}