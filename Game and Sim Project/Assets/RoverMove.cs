using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Real ore") {
            Destroy(collision.gameObject);
        }
        Debug.Log("collision");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Real ore")
            Destroy(gameObject);
        Debug.Log("collision");
    }

    int roverx = -353, rovery = -99;

	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) && roverx > -366) {
            Vector3 tempPos = this.transform.position;
            //tempPos.x--;
            tempPos.x -= 3;
            this.transform.position = tempPos;
            //roverx--;
            roverx -= 3;
        }
        if (Input.GetKey(KeyCode.RightArrow) && roverx < 877)
        {
            Vector3 tempPos = this.transform.position;
            //tempPos.x++;
            tempPos.x += 3;
            this.transform.position = tempPos;
            //roverx++;
            roverx += 3;
        }
        if (Input.GetKey(KeyCode.UpArrow) && rovery < 324)
        {
            Vector3 tempPos = this.transform.position;
            //tempPos.y++;
            tempPos.y += 3;
            this.transform.position = tempPos;
            //rovery++;
            rovery += 3;
        }
        if (Input.GetKey(KeyCode.DownArrow) && rovery > -178)
        {
            Vector3 tempPos = this.transform.position;
            //tempPos.y--;
            tempPos.y -= 3;
            this.transform.position = tempPos;
            //rovery--;
            rovery -= 3;
        }
    }
}
