using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour {

    public GameObject elusive_object;
    public ParticleSystem glitter_particle;

	// Use this for initialization
	void Start () {
        StartCoroutine(Coroutine(7));
    }

    IEnumerator Coroutine(float delayTime)
    {
        while (true)
        {
            if (elusive_object.activeSelf == true)
            {
                glitter_particle.Play();

            }
            else
            {
                glitter_particle.Stop();
                glitter_particle.Clear();
                yield break;
            }


            yield return new WaitForSeconds(delayTime);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
