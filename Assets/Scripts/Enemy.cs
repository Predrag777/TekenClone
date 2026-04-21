using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health=100f;

    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("SSSSS   "+collider.tag);
        if (collider.CompareTag("fist"))
        {
            animator.SetTrigger("hit");
        }
    }
}
