using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    
    private Vector3 initCameraPos;
    private Vector3 initPos;

    public Transform mainCamera;

    public float xrate, yrate;

    void Start() {
        initCameraPos = mainCamera.position;
        initPos = transform.position;
    }

    void LateUpdate() {
        Vector3 newPos = initPos;
        newPos.x += (mainCamera.position - initCameraPos).x * xrate;
        newPos.y += (mainCamera.position - initCameraPos).y * yrate;
        transform.position = newPos;
    }


}
