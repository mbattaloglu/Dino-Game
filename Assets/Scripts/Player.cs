using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;

    private float gravity = 9.81f * 2f;
    public float jumpForce;

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;
        if (character.isGrounded)
        {
            direction = Vector3.down;
            
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                direction = Vector3.up * jumpForce;
            }
        }

        character.Move(direction * Time.deltaTime);
    }

}