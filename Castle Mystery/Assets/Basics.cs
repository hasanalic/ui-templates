using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{
    private void Start()
    {
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