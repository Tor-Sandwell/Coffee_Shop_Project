//Script A
using UnityEngine;
using System.Collections;

public class ClickDetector : MonoBehaviour
{
    private void Update()
    {
        //checks if mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 ScreenCentre;
            ScreenCentre.x = Screen.width / 2;
            ScreenCentre.y = Screen.height / 2;
            ScreenCentre.z = 0;
            //calculates ray from screen point to world point
            Ray ray = Camera.main.ScreenPointToRay(ScreenCentre);
            //checks for a hit and activates IClickable if hit
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickable  clickable = hit.collider.GetComponent<IClickable>();

                clickable?.OnClick();
            }
        }
    }
}