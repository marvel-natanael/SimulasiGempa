using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    private RawImage backgorund;
    private void Start()
    {
        backgorund = GetComponent<RawImage>();
    }
    public IEnumerator shakeCam(float duration, float magnitude)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            backgorund.uvRect = new Rect(x, y, 1, 1);
            elapsed += Time.deltaTime;
            yield return 0;
        }
        backgorund.uvRect = new Rect(0, 0, 1, 1);
    }
}
