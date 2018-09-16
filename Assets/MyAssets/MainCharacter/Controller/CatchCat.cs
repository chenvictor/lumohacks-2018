using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchCat : MonoBehaviour {
    public GameObject catDown;
    public GameObject catUp;

    // Use this for initialization
    void Start()
    {
        catDown.SetActive(false);   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        catDown.SetActive(true);
        catUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
