using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillonHit : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            Destroy(expl, 2f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            Destroy(expl, 2f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();
        }
    }
}
