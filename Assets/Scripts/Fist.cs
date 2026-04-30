using UnityEngine;

public class Fist : MonoBehaviour
{
    BoxCollider myCol;
    [SerializeField] ParticleSystem myVFX;
    [SerializeField] AudioClip sound;
    AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source=GetComponent<AudioSource>();
        myVFX.Stop();
        myCol=GetComponent<BoxCollider>();
        myCol.enabled=false;
    }

    // Update is called once per frame


    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("enemy"))
        {
            myVFX.Play();
            source.PlayOneShot(sound);
            collider.GetComponent<Enemy>().isHit();
        }
    }
}
