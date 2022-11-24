using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenWalk : MonoBehaviour
{
    public float min = 1f;
    public float max = 2f;
    private float chickMin;
    private float chickMax;
    private Vector3 localScale;
    public GameObject enemy;
    private float left;
    private float right;
    public float speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerCar"))
        {
            Destroy(enemy);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        chickMin = transform.position.x;
        chickMax = transform.position.x + max;
        localScale = transform.localScale;
        left = localScale.x;
        right = localScale.x * -1;
    }

    // Update is called once per frame
    void Update()
    {
        var lastVal = transform.position.x;
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, chickMax - chickMin) + chickMin, transform.position.y, transform.position.z);

        if (transform.position.x > lastVal)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, left);

        }
        else if (transform.position.x < lastVal)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, right);
        }
    }
}
