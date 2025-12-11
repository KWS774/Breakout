using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.n

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Destroy(other.gameObject);
        GameManager.Instance.BallManager.ChangeBallCount(-1);
    }

}
