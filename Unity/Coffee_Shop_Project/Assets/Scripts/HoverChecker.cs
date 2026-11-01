using UnityEngine;

public class HoverChecker : MonoBehaviour
{
    [SerializeField] private GameObject hoverCrossHair;
    [SerializeField] private GameObject crossHair;

    void OnMouseOver()
    {
        if (!hoverCrossHair.activeSelf)
        {
            hoverCrossHair.SetActive(true);
            crossHair.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        if (hoverCrossHair.activeSelf)
        {
            hoverCrossHair.SetActive(false);
            crossHair.SetActive(true);
        }
    }
}