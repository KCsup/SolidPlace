using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private CanvasHandler canvasHandler;
    [SerializeField] private Camera cam;

    public float zoomLevel;
    public float sensitivity = 0.15f;
    public float speed = 30;
    public float minZoom = 3;
    public float maxZoom = 30;
    float zoomPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3((float)((canvasHandler.width / 2) - 0.5), canvasHandler.height / 2, -1);
        cam.orthographicSize = 7;
    }


    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y + Input.mouseScrollDelta.y);
        zoomLevel -= Input.mouseScrollDelta.y * sensitivity;
        zoomLevel = Mathf.Clamp(zoomLevel, minZoom, maxZoom);
        zoomPosition = Mathf.MoveTowards(zoomPosition, zoomLevel, speed * Time.deltaTime);
        cam.orthographicSize = (zoomPosition);
    }
}
