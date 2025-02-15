using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public event Action TimerTicked; 

    public void StartCountdown(float delay)
    {
        StartCoroutine(Countdown(delay));
    }

    private IEnumerator Countdown(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (enabled)
        {
            TimerTicked?.Invoke();

            yield return wait;
        }
    }
}