using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalCode2 : MonoBehaviour
{
    private float speed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        this.GetComponent<Transform>().Translate(this.speed * -Time.deltaTime, 0f, 0f);

        //k‰‰nnet‰‰n y akselilla(pystysuunnassa) 180 astetta
        if (this.GetComponent<Transform>().position.x > 15f ||
            this.GetComponent<Transform>().position.x < -15f)
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
    }
}
