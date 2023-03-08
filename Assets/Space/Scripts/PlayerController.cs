using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MaxSpeed = 5.0f;
    public float LateralThrusterForce = 10f;
    private Rigidbody2D rb;
    private float horizontalInput;
    private float drag = 0.4f;

    private LaserSystem laserSystem;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        laserSystem = GetComponent<LaserSystem>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            laserSystem.Fire();
        }
    }

    void FixedUpdate()
    {
        if (horizontalInput != 0.0f)
        {
            float force = horizontalInput * LateralThrusterForce;
            rb.AddForce(new Vector2(force, 0) * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(new Vector2(-rb.velocity.x * (1 / drag), 0));
        }
        
        float clampedVelocity = Mathf.Clamp(rb.velocity.x, -MaxSpeed, MaxSpeed);
        rb.velocity = new Vector2(clampedVelocity, 0);
    }
}
