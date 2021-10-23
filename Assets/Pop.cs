using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period;

    void Start() {
        GetComponent<AudioSource>().Play();
    }

    void Update() {
        if (Time.time >= nextActionTime) {
            nextActionTime += period;
            GetComponent<AudioSource>().Play();
        }
    }
}
