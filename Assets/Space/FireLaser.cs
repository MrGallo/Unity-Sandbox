using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    public int NumLasers = 3;
    public float LaserSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            //laser.transform.Rotate(0f, 0f, i * 10f);
            Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * LaserSpeed;
        }
    }
}
