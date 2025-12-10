using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed = 15f;
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");  // -1〜1 の値が返る

        Vector3 move = new Vector3(h * speed * Time.fixedDeltaTime, 0f, 0f);

        rb.MovePosition(rb.position + move);
    }

}
