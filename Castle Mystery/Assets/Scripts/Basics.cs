using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

    Warrior warrior;

    private void Awake()
    {
        // This is the first function that is called.
        // It is used when initialize variables.
    }

    private void OnEnable()
    {
        // This is the second function that is called.
    }

    private void Start()
    {
        warrior = new Warrior(100, 50, "Warrior");
        warrior.Attack();
        warrior.Info();

        StartCoroutine(ExecuteSomething(2));
        /*
         StartCoroutine("ExecuteSomething");
         StopCoroutine("ExecuteSomething");
         */
    }

    IEnumerator ExecuteSomething(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Something is executed.");
    }
}