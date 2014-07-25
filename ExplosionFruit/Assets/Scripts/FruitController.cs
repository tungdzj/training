using UnityEngine;
using System.Collections;

public class FruitController : MonoBehaviour {

    float speed = 70;
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
