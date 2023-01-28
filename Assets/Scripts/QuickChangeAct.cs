using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickChangeAct : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField]private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left *_speed );
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.right * _speed );
        }

        
}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Color")
        {
            _object.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }
}
