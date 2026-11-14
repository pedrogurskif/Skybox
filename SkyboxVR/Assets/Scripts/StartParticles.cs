using UnityEngine;

public class StartParticles : MonoBehaviour
{
    public ParticleSystem a, b;
    void Start()
    {
        Debug.Log("aee");
        a.Play();
        b.Play();
    }
}
