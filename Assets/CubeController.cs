using UnityEngine;

public class CubeController : MonoBehaviour
{
    // These 'public' variables will show up in your Unity Inspector
    [Header("Movement")]
    public float moveSpeed = 2f;
    public Vector3 moveDirection = new Vector3(1, 0, 0); // Moves Right

    [Header("Rotation")]
    public float rotationSpeed = 50f;
    public Vector3 rotationAxis = new Vector3(0, 1, 0); // Spins like a top

    [Header("Scale")]
    public float scaleSpeed = 0.2f;
    public float maxScale = 4f;

    void Update()
    {
        // 1. Translate (Move)
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // 2. Rotate
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);

        // 3. Scale (Increases until it hits the max limit)
        if (transform.localScale.x < maxScale)
        {
            transform.localScale += new Vector3(1, 1, 1) * scaleSpeed * Time.deltaTime;
        }
    }
}