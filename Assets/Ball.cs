using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        rb.velocity = new Vector3(1f, 0f, -1f).normalized * speed;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.TryGetComponent<Ball>
        //GameManager.Instance.BallManager.ChangeBallCount(1);
    }

}
