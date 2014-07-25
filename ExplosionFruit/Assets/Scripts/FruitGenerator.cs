using UnityEngine;
using System.Collections;

public class FruitGenerator : MonoBehaviour {
    public GameObject[] fruits;
    float timeToSpawnFruit = 1, _timeToSpawnFruit = 0;
    System.Random rnd;
    float left = -15, right = 15;
	// Use this for initialization
	void Start ()
    {
        rnd = new System.Random();
	}
	// Update is called once per frame
	void Update ()
    {
        _timeToSpawnFruit += Time.deltaTime;
        if (_timeToSpawnFruit > timeToSpawnFruit)
        {
            _timeToSpawnFruit = 0;
            SpawnFruit();
        }
	}
    void SpawnFruit()
    {
        float x = left + rnd.Next((int)left, (int)right);
        GameObject.Instantiate(fruits[rnd.Next(0, fruits.Length)],
            new Vector3(x,40,0),
            Quaternion.identity);
    }
}
