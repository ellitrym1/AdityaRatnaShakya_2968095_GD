using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Animator animator;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // if (horizontalInput != 0f && verticalInput != 0f)
        // {
        //     if (Mathf.Abs(horizontalInput) > Mathf.Abs(verticalInput))
        //     {
        //         verticalInput = 0f;
        //     }
        //     else
        //     {
        //         horizontalInput = 0f;
        //     }
        
        // }

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement); 

        animator.SetFloat("Horizontal", horizontalInput);
        animator.SetFloat("Vertical", verticalInput);

        
    }
}
