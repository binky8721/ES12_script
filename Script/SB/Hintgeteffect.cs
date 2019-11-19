using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hintgeteffect : MonoBehaviour {

     bool effectIsplaying = false;

    public float waveSpeed = 1.0f;
    private float offset = 0.5f;
    private float elapsed = 0.0f;

    bool sizing = false;
    

    void Start () {
        //StartCoroutine(Coroutine_gethint(10));
    }


    void Update()
    {
        if(!effectIsplaying)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else if (effectIsplaying)
        {
            elapsed += waveSpeed * Time.deltaTime;
            float wave = (Mathf.Sin(elapsed) * 0.05f + offset); //가운데 숫자로 커졌다 작아졌다 범위 조절
            Vector3 MaxScale = new Vector3(2.0f, 2.0f, 2.0f); //바뀌는 범위의 최대값
            transform.localScale = Vector3.Slerp(transform.localScale, MaxScale * wave, waveSpeed * Time.deltaTime);
        }
    }

    void pound()
    {
        
        elapsed += waveSpeed * Time.deltaTime;
        float wave = (Mathf.Sin(elapsed) * 0.15f + offset);
        Vector3 MaxScale =  new Vector3(2.0f, 2.0f, 2.0f);
        transform.localScale = Vector3.Slerp(transform.localScale, MaxScale*wave, waveSpeed * Time.deltaTime);
        
        /*
        elapsed += waveSpeed * Time.deltaTime;
        float wave = (Mathf.Sin(elapsed) * 0.5f + offset);
        Vector3 MaxScale = transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        transform.localScale = Vector3.Slerp(transform.localScale, MaxScale * wave, waveSpeed * Time.deltaTime);
        */

    }

    public void hinteffectstop()
    {
        effectIsplaying = false;
        //transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //transform.gameObject.SetActive(false);
        //StopCoroutine("Coroutine_gethint");
    }

    public void Starthinteffect()
    {
        effectIsplaying = true;
        //StartCoroutine(Coroutine_gethint());
    }
    
    IEnumerator Coroutine_gethint()
    {

            if (effectIsplaying == false)
            {
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                yield break;
            }

        //yield return new WaitForSeconds(delayTime);

        /*
        while (true)
        {

            if (sizing)
            {
                transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
                if (gameObject.transform.localScale.x > 1.5)
                    sizing = false;
            }
            else
            {
                transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
                if (gameObject.transform.localScale.x < 1.0)
                    sizing = true;
            }
            yield return new WaitForSeconds(0.01f);
        }
        */
    }
   

}
