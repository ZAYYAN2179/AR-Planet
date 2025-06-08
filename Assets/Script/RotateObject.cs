using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 50f;

    void Update()
    {
        // Planet akan terus berputar secara otomatis
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
