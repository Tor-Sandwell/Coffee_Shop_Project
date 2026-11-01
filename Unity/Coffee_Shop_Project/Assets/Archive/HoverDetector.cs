using UnityEngine;
using System.Collections;

public class HoverDetector : MonoBehaviour
{

    [SerializeField] private GameObject crossHair;
    [SerializeField] private GameObject hoverCrossHair;

    void Update()
    {
        Vector3 ScreenCentre;
        ScreenCentre.x = Screen.width / 2;
        ScreenCentre.y = Screen.height / 2;
        ScreenCentre.z = 0;

        Ray ray = Camera.main.ScreenPointToRay(ScreenCentre);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            IHoverable hoverable = hit.collider.GetComponent<IHoverable>();

            hoverable?.OnHover();
        }
    }
    void OnHover()
    {
        Debug.Log("Not Hover");
        if (!crossHair.activeSelf)
        {
            Debug.Log("Hover exited");
            crossHair.SetActive(false);

            hoverCrossHair.SetActive(true); 
        }
    }
}