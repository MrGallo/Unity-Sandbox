using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    [SerializeField]
    private float laserSpeed = 15f;

    private GameObject owner;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CollidesWithOwner(collision)) return;
        if (CollidesWithBoundary(collision)) return;
        if (CollidesWithLaser(collision)) return;

        ApplyDamageIfApplicable(collision);
        Destroy(gameObject);
    }


    private void ApplyDamageIfApplicable(Collider2D collision)
    {
        Health healthComponent = collision.GetComponent<Health>();

        if (healthComponent)
            healthComponent.TakeDamage(20);
    }

    private bool CollidesWithBoundary(Collider2D collision)
    {
        return collision.CompareTag("Boundary");
    }

    private bool CollidesWithOwner(Collider2D collision)
    {
        return this.owner == collision.gameObject;
    }
    private bool CollidesWithLaser(Collider2D collision)
    {
        return collision.CompareTag("Laser");
    }

    public void Fire(GameObject owner)
    {
        this.owner = owner;
        gameObject.transform.rotation = this.owner.transform.rotation;
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * laserSpeed;
    }

    public GameObject GetOwner() { return owner; }

}
