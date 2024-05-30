using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Player GameObject to rotate around
    public float rotationSpeed = 5.0f; // Speed of camera rotation

    private Vector3 offset; // Offset between camera and player

    void Start()
    {
        // Calculate initial offset between camera and player
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Get mouse input for camera rotation
        float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;
        float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed;

        // Rotate the camera horizontally around the player
        player.Rotate(Vector3.up * horizontalInput);

        // Rotate the camera vertically around the player
        transform.RotateAround(player.position, player.right, -verticalInput);

        // Apply the offset to keep the camera at the same distance from the player
        transform.position = player.position + offset;
    }
}