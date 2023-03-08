using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        StartCoroutine(Fire());
    }

    void Update()
    {
        if (player)
        {
            Vector2 direction = (gameObject.transform.position - player.transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.3f);
            if (!player)
                break;
            GetComponent<LaserSystem>().Fire();

        }
    }
}
