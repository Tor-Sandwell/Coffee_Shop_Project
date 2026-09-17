//Script A
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private void Update()
    {
        //checks if mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //calculates ray from screen point to world point
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //checks for a hit and activates IClickable if hit
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickable  clickable = hit.collider.GetComponent<IClickable>();

                clickable?.OnClick();
            }
        }
    }
}