using UnityEngine;
using UnityEngine.Events;

public class HoverableObject : MonoBehaviour, IHoverable
{
    [SerializeField] private UnityEvent onHoverAction;

    [SerializeField] private GameObject crossHair;
    [SerializeField] private GameObject hoverCrossHair;

    public void OnHover()
    {
        onHoverAction?.Invoke();
        if (hoverCrossHair.activeSelf)
        {
            hoverCrossHair.SetActive(false);

            crossHair.SetActive(true);
        }
    }
    public void OnHoverExit()
    {

    }
}