using UnityEngine;
using System.Collections;

public class RightLeftMovement : MonoBehaviour {
    public float speed = 6.0F;
	public int playerNum;
    private Vector3 moveDirection = Vector3.zero;
    void Update() {
        moveDirection = new Vector3(Input.GetAxis("Horizontal " + playerNum), -Input.GetAxis("Vertical " + playerNum), 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        transform.Translate(moveDirection * Time.deltaTime);
    }
	
	void Start(){
		
	}
}