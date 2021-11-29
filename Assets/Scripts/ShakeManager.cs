using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeManager : MonoBehaviour
{
    private Shake shake;

    [SerializeField]
    float duration, magnitude;
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("Shake").GetComponent<Shake>();
        Debug.Log(shake.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shakeCamera()
    {
        StartCoroutine(shake.shakeCam(duration, magnitude));
    }
}
