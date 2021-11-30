using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeManager : MonoBehaviour
{
    private Shake shake;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("Shake").GetComponent<Shake>();
    }

    public void shakeCamera(float magnitude)
    {
        StartCoroutine(shake.shakeCam(magnitude));
    }

    public void onPressed(string pressedButton)
    {
        switch(pressedButton)
        {
            case "kiri":
                {
                    Shake.left = true;
                    break;
                }
            case "kanan":
                {
                    Shake.right = true;
                    break;
                }
        }
    }

    public void onLift(string pressedButton)
    {
        switch (pressedButton)
        {
            case "kiri":
                {
                    Shake.left = false;
                    break;
                }
            case "kanan":
                {
                    Shake.right = false;
                    break;
                }
        }
    }
}
