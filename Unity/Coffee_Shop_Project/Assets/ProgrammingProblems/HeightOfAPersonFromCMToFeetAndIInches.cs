using UnityEngine;

public class HeightOfAPersonFromCMToFeetAndIInches : MonoBehaviour
{
    private int heightInCM;
    private void Start()
    {
            heightInCM = 101;
            CMToFeetAndInches(heightInCM);
            heightInCM = 3;
            CMToFeetAndInches(heightInCM);
            heightInCM = 15;
            CMToFeetAndInches(heightInCM);
            heightInCM = 192;
            CMToFeetAndInches(heightInCM);
            heightInCM = 124;
            CMToFeetAndInches(heightInCM);
    }
    private void CMToFeetAndInches(int heightInCM)
    {
        int inchConversion = heightInCM * 100;
        int inches = inchConversion / 254;
        Debug.Log("Height in Inches: " + inches);
        int feet = inches / 12;
        int remainingInches = inches % 12;
        Debug.Log("Height in Feet and inches: " + feet + " feet and " + remainingInches + " inches to the nearest inch");
    }
}