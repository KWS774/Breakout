using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float totalTime;
    public float TotalTime => totalTime;

    // Update is called once per frame
    private void Update()
    {
        totalTime += Time.deltaTime;
    }

    public void ResetTime()
    {
        totalTime = 0;
    }

}
