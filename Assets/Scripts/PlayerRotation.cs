using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    public float rotationSpeed;
    private Vector3 mousePosition;
    private Camera cam;

    private Quaternion targetRotation;

    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = cam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, cam.transform.position.y - transform.position.y));

        targetRotation = Quaternion.LookRotation(mousePosition - new Vector3(transform.position.x, 0, transform.position.z));

        transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);

    }
}
