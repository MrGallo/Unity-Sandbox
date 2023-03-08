using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSystem : MonoBehaviour
{
    public GameObject LaserPrefab;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        GameObject laser = Instantiate(LaserPrefab, transform.position, Quaternion.identity);
        LaserController laserController = laser.GetComponent<LaserController>();
        laserController.Fire(gameObject);
    }
}
