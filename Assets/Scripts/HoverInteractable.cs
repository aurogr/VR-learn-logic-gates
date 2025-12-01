using UnityEngine;

public class HoverInteractable : MonoBehaviour
{
    [SerializeField][Range (0, 100)] int hoverColorAmount;
    MeshRenderer[] meshesRenderer;
    public void Awake()
    {
        meshesRenderer = GetComponents<MeshRenderer>();
    }
    public void AddHoverColor()
    {
        foreach (MeshRenderer renderer in meshesRenderer)
        {
            renderer.material.color = new Color(renderer.material.color.r + hoverColorAmount, renderer.material.color.g + hoverColorAmount, renderer.material.color.b + hoverColorAmount);
        }
    }
    public void RemoveHoverColor()
    {
        foreach(MeshRenderer renderer in meshesRenderer)
        {
            renderer.material.color = new Color(renderer.material.color.r - hoverColorAmount, renderer.material.color.g - hoverColorAmount, renderer.material.color.b - hoverColorAmount);
        }
    }
}