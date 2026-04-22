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
    }

    void healthControl()
    {
        healthUI.fillAmount=(health/100f);    /////////
    }
}
