using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * moveInput * moveSpeed * Time.deltaTime);
    }
}
