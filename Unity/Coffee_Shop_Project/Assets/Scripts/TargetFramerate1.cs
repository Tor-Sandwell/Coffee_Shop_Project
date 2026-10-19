using UnityEngine;

public class Framerate : MonoBehaviour
{
    public int FrameTarget = 60;
    private void Awake()
    {
        Application.targetFrameRate = FrameTarget;
    }
}
