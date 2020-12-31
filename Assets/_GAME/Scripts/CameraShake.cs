using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    
   public IEnumerator Shake(float p_Duration, float p_Magnitude)
   {

        Vector3 l_OriginalPos = transform.localPosition;

        float l_Elapsed = 0.0f;

        while(l_Elapsed < p_Duration)
        {
            float l_XPos = Random.Range(-1f, 1f) * p_Magnitude;
            float l_YPos = Random.Range(-1f, 1f) * p_Magnitude;

            transform.localPosition = new Vector3(l_XPos, l_YPos, l_OriginalPos.z);
            l_Elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = l_OriginalPos;

   }

    public void Shake()
    {
        StartCoroutine(Shake(0.1f, 0.1f));
    }



}
