using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    private int _n = 24;
    void Start()
    {
        int _n = 4;
        CalculateForN(_n);
    }

    private void CalculateForN(int _n)
    {
        _n = _n*3;
        Debug.Log(_n);
    }
}