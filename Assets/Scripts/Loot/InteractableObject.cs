using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private Material originalMaterial;
    public Material highlightMaterial;

    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponentInChildren<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogError($"Renderer не найден на {gameObject.name}");
            return;
        }

        originalMaterial = objectRenderer.material;
    }

    public void Highlight()
    {
        if (objectRenderer != null)
            objectRenderer.material = highlightMaterial;
    }

    public void UnHighlight()
    {
        if (objectRenderer != null)
            objectRenderer.material = originalMaterial;
    }
}