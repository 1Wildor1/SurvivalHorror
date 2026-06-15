using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance = 3f;

    private InteractableObject currentObject;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
        {
            InteractableObject interactable =
                hit.collider.GetComponent<InteractableObject>();

            if (interactable != null)
            {
                if (currentObject != interactable)
                {
                    if (currentObject != null)
                        currentObject.UnHighlight();

                    currentObject = interactable;
                    currentObject.Highlight();
                }
            }
            else
            {
                ClearHighlight();
            }
        }
        else
        {
            ClearHighlight();
        }
    }

    void ClearHighlight()
    {
        if (currentObject != null)
        {
            currentObject.UnHighlight();
            currentObject = null;
        }
    }
}