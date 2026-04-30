using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public float health=100f;
    [SerializeField] Image healthUI;

    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator=GetComponent<Animator>();
    }


    void LateUpdate()
    {
        transform.rotation=Quaternion.Euler(0f,180f,0f);

        Vector3 pos=transform.position;
        pos.x=1.6f;
        transform.position=pos;
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
