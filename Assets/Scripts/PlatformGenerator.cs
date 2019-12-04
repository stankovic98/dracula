using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    public GameObject platform;
    public Transform generationPoint;

    private float platformWidth;

    void Start() {
        platformWidth = platform.GetComponentInChildren<BoxCollider>().size.z;
    }

    void Update() {

        if (transform.position.z < generationPoint.transform.position.z) {
            transform.position = new Vector3(transform.position.x, transform.position.y,  transform.position.z + platformWidth);
            Instantiate(platform, transform.position, transform.rotation);
        }
    }
}
