using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAround : MonoBehaviour {

    // Use this for initialization
    public float rotateSpeed = 10f;

	void OnMouseDrag () {
        float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, roty);
    }
}
