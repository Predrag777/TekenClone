using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    float speed=2f;

    CharacterController controller;
    Enemy enemy;



    bool punchLog;
    bool kickLog;

    void Start()
    {
        enemy=GetComponent<Enemy>();
        controller=GetComponent<CharacterController>();
    }

    void Update()
    {
        if(enemy.health<=0f) return;
        //makeMove();
    }

    void decision()
    {
        
    }

    void makeMove()
    {
        if(Vector3.Distance(transform.position, target.position)>=0.5f)
        {
            Vector3 dir=target.position-transform.position;
            controller.Move(dir*speed*Time.deltaTime);
        }
    }
}
