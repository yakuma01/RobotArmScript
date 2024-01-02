using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm_Robot : MonoBehaviour
{
    [Header("Parts")]
    public Transform Arm;
    public Transform Forearm;
    public Transform DigitUpperBase;
    public Transform DigitUpperEnd;
    public Transform DigitLowerBase;
    public Transform DigitLowerEnd;
    [Header("Joints")]
    public Transform Shoulder;
    public Transform Elbow;
    public Transform WristUpper;
    public Transform WristLower;
    public Transform KnuckleUpper;
    public Transform KnuckleLower;

    // Start is called before the first frame update
    void Start()
    {
        Arm.localScale = new Vector3(2,1,1);
        Forearm.localScale = new Vector3(2,1,1);
        DigitUpperBase.localScale = new Vector3(1,0.5f,1);
        DigitUpperEnd.localScale = new Vector3(1,0.5f,1);
        DigitLowerBase.localScale = new Vector3(1,0.5f,1);
        DigitLowerEnd.localScale = new Vector3(1,0.5f,1);
        Arm.localPosition = new Vector3(1,-0.5f);
        Forearm.localPosition = new Vector3(1,-0.5f);
        DigitUpperBase.localPosition = new Vector2(0.5f,-0.25f);
        DigitUpperEnd.localPosition = new Vector2(0.5f,0.25f);
        DigitLowerBase.localPosition = new Vector2(0.5f,0.25f);
        DigitLowerEnd.localPosition = new Vector2(0.5f,-0.25f);
        Shoulder.localPosition = new Vector2(0,0);
        Elbow.localPosition = new Vector2(2,0);
        WristUpper.localPosition = new Vector2(2,0);
        WristLower.localPosition = new Vector2(2,-1);
        KnuckleUpper.localPosition = new Vector2(1,-0.5f);
        KnuckleLower.localPosition = new Vector2(1,0.5f);
        Shoulder.localEulerAngles = (Shoulder.forward * -20);
        Elbow.localEulerAngles = (Elbow.forward * 40);
        WristUpper.localEulerAngles = (WristUpper.forward * 45);
        KnuckleUpper.localEulerAngles = (KnuckleUpper.forward * -75);
        WristLower.localEulerAngles = (WristLower.forward * -45);
        KnuckleLower.localEulerAngles = (KnuckleLower.forward * 70);
    }

    // Update is called once per frame
    void Update()
    {
        //Elbow.localEulerAngles += Vector3.forward * Time.deltaTime * 60;
        Shoulder.localEulerAngles -= Vector3.forward * Time.deltaTime * 80;
        WristUpper.localEulerAngles -= Vector3.forward * Mathf.Sin(Time.deltaTime + 0.05f);
        WristLower.localEulerAngles -= Vector3.forward * Mathf.Sin(Time.deltaTime - 0.05f);
    }
}
