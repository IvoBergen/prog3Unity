using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getpickup : MonoBehaviour
{
    private Renderer r;
    private AudioSource source;
    private ParticleSystem ps;
    private Keepscore scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        scoreScript = FindAnyObjectByType<Keepscore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Players")
        {
            r.enabled = false;
            Destroy(gameObject, 0.5f);
            GetComponent<Collider>().enabled = false;
            source.Play();
            ps.Play();
            scoreScript.AddScore(5);
        }
    }
}
