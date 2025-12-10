using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update


    //ƒ{[ƒ‹‚ªÁ‚¦‚½‚ç



    private int ballCount = 0;
    public int BallCount => ballCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeBallCount(int n)
    {
        ballCount += n;
    }

}
