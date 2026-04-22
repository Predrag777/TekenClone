using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    [SerializeField] float health=100f;
    [SerializeField] Image healthUI;

    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator=GetComponent<Animator>();
    }


    public void isHit()
    {
        animator.SetTrigger("hit");
        health-=10;
        healthControl();//

        if (health <= 0f){
            Debug.Log("MRTAV");
            animator.SetTrigger("death");
        }
        
    }

    void healthControl()
    {
        healthUI.fillAmount=(health/100f);    /////////
    }
}
