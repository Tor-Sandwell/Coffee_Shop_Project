using UnityEngine;

public class FnafCamera : MonoBehaviour
{
    [SerializeField] private float officeScrollSpeed;

    private Camera fnafCamera;
    private float defaultAngle;

    private void Start()
    {
        fnafCamera = GetComponentInChildren<Camera>();
    }

    private void Update()
    {

    }
}
