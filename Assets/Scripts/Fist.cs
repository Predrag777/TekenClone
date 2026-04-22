using UnityEngine;

public class Fist : MonoBehaviour
{
    BoxCollider myCol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCol=GetComponent<BoxCollider>();
        myCol.enabled=false;
    }

    // Update is called once per frame


    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("enemy"))
        {
            collider.GetComponent<Enemy>().isHit();
        }
    }
}
