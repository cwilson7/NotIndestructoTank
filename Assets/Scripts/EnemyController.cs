using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody rb;

    public GameObject _player;

    float runSpeed = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        rb.velocity = (_player.transform.position - transform.position).normalized * runSpeed;
    }
}
