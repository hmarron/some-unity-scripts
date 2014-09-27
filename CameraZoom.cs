using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	
	public int playerNum;
	public float zoomSpeed;
	
	void Update () {
		if(camera.orthographic){
			if(camera.orthographicSize >= 0){
				camera.orthographicSize += Input.GetAxis("Zoom " + playerNum) * zoomSpeed * Time.deltaTime;
			} else {
				camera.orthographicSize = 0;
			}
		}else{
			if(camera.transform.position.z > minZ && camera.transform.position.z < maxZ){
				//camera.transform.position += ;
				camera.transform.position = new Vector3(camera.transform.position.x,camera.transform.position.y,
					camera.transform.position.z + (Input.GetAxis("Zoom " + playerNum) * zoomSpeed * Time.deltaTime));
			}
			if(camera.transform.position.z > maxZ){
				camera.transform.position = new Vector3(camera.transform.position.x,camera.transform.position.y,maxZ);
			}else if(camera.transform.position.z < minZ){
				camera.transform.position = new Vector3(camera.transform.position.x,camera.transform.position.y,minZ);
			}
		}
			
	}
}
