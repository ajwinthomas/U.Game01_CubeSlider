using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Transform transform;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      transform = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = offset + target.position;
    }
}
