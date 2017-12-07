using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orient : MonoBehaviour {

    [SerializeField] Camera myCamera;


    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f;
    public float panSpeed = 0.005f; // todo make betterer

    Text[] textBoxes;


	// Use this for initialization
	void Start () {
        textBoxes = GetComponentsInChildren<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            PanCamera();
        }
        else if (Input.touchCount == 2)
            PinchZoom();
    }

    private void PanCamera()
    {
        Touch touchZero = Input.GetTouch(0);
        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
        myCamera.transform.position = (touchZero.position - touchZeroPrevPos) * panSpeed;
    }

    private void PinchZoom()
    {

        // Store both touches.
        Touch touchZero = Input.GetTouch(0);
        Touch touchOne = Input.GetTouch(1);

        // Find the position in the previous frame of each touch.
        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
        Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

        // Find the magnitude of the vector (the distance) between the touches in each frame.
        float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
        float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

        // Find the difference in the distances between each frame.
        float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

        // If the myCamera is orthographic...
        if (myCamera.orthographic)
        {
            // ... change the orthographic size based on the change in distance between the touches.
            myCamera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

            // Make sure the orthographic size never drops below zero.
            myCamera.orthographicSize = Mathf.Max(myCamera.orthographicSize, 0.1f);
        }
        else
        {
            // Otherwise change the field of view based on the change in distance between the touches.
            myCamera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

            // Clamp the field of view to make sure it's between 0 and 180.
            myCamera.fieldOfView = Mathf.Clamp(myCamera.fieldOfView, 30f, 60f);
        }
    }
}
