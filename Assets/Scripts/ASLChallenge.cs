using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASLChallenge : MonoBehaviour
{
    [SerializeField] private int _age;
    [SerializeField] private string _sex, _location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Your age is " + _age + " and your sex is " + _sex  + " and your location is " + _location);
        }
    }
}
