using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {
	float speed = 20;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.LeftArrow))    //check if player press Left Arrow
		{
            transform.Translate(-speed * Time.deltaTime, 0, 0);     //move object along x axis (to the left)
            if (transform.position.x < -15)           //if object reach left border
            {
                transform.position = new Vector3(-15, transform.position.y, transform.position.z);
            }
		}
        if (Input.GetKey(KeyCode.RightArrow))   //check if player press Right Arrow
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);      //move object along x axis (to the right)
            if (transform.position.x > 15)           //if object reach left border
            {
                transform.position = new Vector3(15, transform.position.y, transform.position.z);
            }
        }
	}
}
