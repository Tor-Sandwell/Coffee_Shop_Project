using UnityEngine;

public class DiceSimuulator : MonoBehaviour
{
    void Dice()
    {
            int diceRoll = UnityEngine.Random.RandomRange(1, 7);
            Debug.Log(diceRoll);
            if (diceRoll == 6)
            {
                Debug.Log ("Critical Hit");
            }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Dice();
        }
    }
}
