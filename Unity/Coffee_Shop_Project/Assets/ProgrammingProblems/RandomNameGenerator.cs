using UnityEngine;

public class RandomNameGenerator : MonoBehaviour
{
    string[] names = { "Pomni", "Jax", "Ragatha", "Zooble", "Kinger", "Gangle", "Caine", "Bubble"};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (names.Length > 0)
            {
                int randomIndex = UnityEngine.Random.RandomRange(0, names.Length);
                Debug.Log(names[randomIndex]);
            }
            else
            {
                Debug.Log("No names available.");
            }
        }
    }
}
