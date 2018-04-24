using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMover : MonoBehaviour {

    // Object to be moved
    public GameObject Cube;

    // Start and end position
    private Vector3 startPosition;
    private Vector3 endPosition;

    // Distance to move
    private float distance = 80;

    // Travel time
    private float lerpTime = 2.5f;

    // Keep track of current lerp time
    private float currentLerpTime = 0;

    private bool keyHit = false;

    void Start ()
    {
        startPosition = Cube.transform.position;
        endPosition = Cube.transform.position + Vector3.left * distance;
    }

    // Update is called once per frame
    void Update() {

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                keyHit = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            keyHit = true;
        }

        if (keyHit)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }

            float perc = currentLerpTime / lerpTime;
            Cube.transform.position = Vector3.Lerp(startPosition, endPosition, perc);
        }

        if(Cube.transform.position == endPosition)
        {
            Cube.SetActive(false);
        }
	}
}
