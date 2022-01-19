using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tarjet;
    public int speed;
    void Start()
    {
        if (tarjet == null)
        {
            tarjet = this.gameObject.transform;
            Debug.Log("RotateAround tarjet not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(tarjet.transform.position, tarjet.transform.up, speed * Time.deltaTime);
    }
}
