using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class dog1Code : MonoBehaviour
{
    //nopeus s‰‰tˆ
    private float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        //liikutetaan x akselilla (vaakasuunnassa)
        this.GetComponent<Transform>().Translate(this.speed * Time.deltaTime, 0f, 0f);

        //k‰‰nnet‰‰n y akselilla(pystysuunnassa) 180 astetta
        if(this.GetComponent<Transform>().position.x > 15f ||
            this.GetComponent<Transform>().position.x < -15f)
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
    }
}
