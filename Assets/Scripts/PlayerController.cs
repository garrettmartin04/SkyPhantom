using UnityEngine;
using UnityEngine.InputSystem; // needed for InputValue

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;

    void Update()
    {
        transform.Translate(Vector2.right * moveInput.x * speed * Time.deltaTime);
    }

    // Called automatically by Player Input (Send Messages mode)
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}