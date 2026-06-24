using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light flashlightLight;

    public bool canUse = false;

    private bool isOn = false;

    void Start()
    {
        flashlightLight.enabled = false;
    }

    void Update()
    {
        if (!canUse)
            return;

        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            flashlightLight.enabled = isOn;
        }
    }
}