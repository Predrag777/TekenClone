using UnityEngine;

public class CombatControl : MonoBehaviour
{
    Animator animator;

    [Header("Colliders")]
    public BoxCollider jab;
    public BoxCollider cross;
    public BoxCollider highKick;
    public BoxCollider spinKick;


    

    int c=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

        jab.enabled=false;
        cross.enabled=false;
        highKick.enabled=false;
        spinKick.enabled=false;
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
        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("topAttack");///////////////////
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("pushAttack");//////////////////////////////
        }
    }    
    
    

    ///////////////////////////////JAB
    public void activeAttackJab()
    {
        jab.enabled=true;
    }

    public void deactiveAttackJab()
    {
        jab.enabled=false;
    }





    ///////////////////////////////////Cross
    public void activeAttackCross()
    {
        cross.enabled=true;
    }

    public void deactiveAttackCross()
    {
        cross.enabled=false;
    }






    //////////////////////////High Kick
    public void activeAttackHigh()
    {
        highKick.enabled=true;
    }

    public void deactiveAttackHigh()
    {
        highKick.enabled=false;
    }




    //////////////////////////SPIN KICK
    public void activeAttackSpin()
    {
        spinKick.enabled=true;
    }

    public void deactiveAttackSpin()
    {
        spinKick.enabled=false;
    }


}
