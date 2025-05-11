using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string[] HeadBools;
    [SerializeField] private string[] BodyBools;
    [SerializeField] private string[] EyeBools;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        SetBooleanHead("HeadDefault");
        SetBooleanBody("BodyDefault");
        SetBooleanEyes("BlueEyes");

    }

    
    public void SetBooleanHead(string headBool)
    {
        SetExclusiveBoolean(HeadBools, headBool);
    }

    public void SetBooleanBody(string bodyPartBool)
    {
        SetExclusiveBoolean(BodyBools, bodyPartBool);
    }


    public void SetBooleanEyes(string eyeBool)
    {
        SetExclusiveBoolean(EyeBools, eyeBool);
    }


    //Check all of the String values of BodyBools 
    //Set false all of the animator.boolean values except from the Boolean with the same string
    private void SetExclusiveBoolean(string[] boolList, string targetBool)
    {
        bool found = false;

        foreach (string boolName in boolList)
        {
            bool isActive = boolName == targetBool;
            animator.SetBool(boolName, isActive);
            if (isActive) found = true;
        }

        if (!found)
        {
            Debug.LogWarning($"Animator bool '{targetBool}' not found in the provided list.");
        }
    }

}
