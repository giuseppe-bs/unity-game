using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarPlaneta : MonoBehaviour {

    // Use this for initialization
    private float rotateSpeed = 100f;

	void OnMouseDrag () {
        float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, roty);
    }
}
