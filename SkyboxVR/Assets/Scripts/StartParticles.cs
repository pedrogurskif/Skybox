using UnityEngine;

public class StartParticles : MonoBehaviour
{
    public ParticleSystem a, b;
    void Start()
    {
        Debug.Log("Cena carregada");
        a.Play();
        b.Play();
    }
}
