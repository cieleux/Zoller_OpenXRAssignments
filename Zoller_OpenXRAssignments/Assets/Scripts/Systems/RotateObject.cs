using UnityEngine;

public sealed class RotateObject : MonoBehaviour
{
    /// </summary>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] 
    private float rotationSpeed = 250.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}
