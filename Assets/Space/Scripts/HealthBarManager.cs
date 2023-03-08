using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    //GameObject healthBar;
    float maxWidth;

    //Color fullColor = new Color(0.682353f, 0.7176471f, 0.3843138f);
    //Color emptyColor = Color.red;

    Health health;

    // Start is called before the first frame update
    void Start()
    {
        //healthBar = Instantiate(gameObject);
        gameObject.transform.localScale = new Vector3(1.15f, 0.1485728f, 1f);
        maxWidth = gameObject.transform.localScale.x;
        health = GetComponentInParent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = gameObject.transform.localScale;
        float percent = health.GetPercent();
        scale.x = percent * maxWidth;
        gameObject.transform.localScale = scale;
    }

    public void SetWidth(float percent)
    {
        Debug.Log(percent);
        //Vector3 old = healthBar.transform.localScale;
        //healthBar.transform.localScale = new Vector3(maxWidth * percent, old.y, old.z);
        //healthBar.GetComponent<SpriteRenderer>().color = Color.Lerp(emptyColor, fullColor, percent);
    }
}
