using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Springiness = 3.0f;

    private Vector3 _offset;

    private void Start()
    {
        if (Target == null)
        {
            Debug.LogError("No Target set for CameraFollow script");
            return;
        }

        _offset = transform.position - Target.transform.position;
    }

    private void Update()
    {
        Vector3 newPos = Target.transform.position + _offset;

        transform.position = Vector3.Lerp(transform.position, newPos, Springiness * Time.deltaTime);
    }
}
