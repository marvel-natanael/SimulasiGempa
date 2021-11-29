using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    private RawImage backgorund;
    public static float mg = 0.0f;
    public static bool left , right;
    public Text magnitudeText;

    private void Start()
    {
        backgorund = GetComponent<RawImage>();
    }

    public IEnumerator shakeCam(float magnitude)
    {
        mg = magnitude;
        float duration = 3.15f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            if (left && right)
            {
                magnitudeText.text = "AMAN";
                magnitudeText.color = new Color(0.0f, 1.0f, 0.0f);
            }
            else
            {
                magnitudeText.text = "RAWAN";
                magnitudeText.color = new Color(1.0f, 0.0f, 0.0f);
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                backgorund.uvRect = new Rect(x, y, 1, 1);
                elapsed += Time.deltaTime;
            }

            yield return 0;
        }
        backgorund.uvRect = new Rect(0, 0, 1, 1);
    }
}
