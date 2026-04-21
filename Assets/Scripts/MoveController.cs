using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float speed=5f;
    [SerializeField] float jumpForce=7f;
    [SerializeField] float gravity=-9.81f;

    CharacterController controller;
    Animator animator;

    float verticalVelocity=0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller=GetComponent<CharacterController>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        makeMove();
        makeJump();
    }

    void makeMove()
    {
        float horizontal = 0f;
        if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
        else if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;

        animator.SetBool("isMove", horizontal != 0f);

        /*if (horizontal != 0f)
        {
            float targetAngle = horizontal > 0f ? 0f : 180f;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
        }*/

        Vector3 dir=new Vector3(0f, verticalVelocity, horizontal);
        
        controller.Move(dir*speed*Time.deltaTime);
    }

    void makeJump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -1f;

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpForce;
                animator.SetTrigger("jump");
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;///////////
        }
    }
}
