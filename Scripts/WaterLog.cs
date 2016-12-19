using UnityEngine;
using System.Collections;

public class WaterLog : MonoBehaviour {

    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
