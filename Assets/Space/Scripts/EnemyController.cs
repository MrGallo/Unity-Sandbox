using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.3f);
            GetComponent<LaserSystem>().Fire();
        }
    }
}
