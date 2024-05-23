using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public AudioClip walk;
    private AudioSource audioSource;

    public float movementSpeed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component attached to the GameObject
        if (audioSource == null)
        {
            // If AudioSource component is not found, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

      private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);
        movement.Normalize();

        rb.velocity = movement * movementSpeed;

        if (movement != Vector2.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
            if (!audioSource.isPlaying)
            {
                audioSource.clip = walk;
                audioSource.Play();
            }
        }
    }
}
