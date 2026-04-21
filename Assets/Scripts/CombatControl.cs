using UnityEngine;

public class CombatControl : MonoBehaviour
{
    Animator animator;

    int c=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        makeAttack();
    }

    void makeAttack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("punch");//////
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("kick");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("spinKick");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("jab");
        }
    }
}
