using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    [SerializeField] private GameObject[] _objects;
    [SerializeField]private int _index;
    [SerializeField] private bool _hasHit;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _objects[_index].GetComponent<Rigidbody>().useGravity = true;          
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            if (_index < _objects.Length)
            {
                other.GetComponent<MeshRenderer>().material.color = Color.red;
                _index++;
                if(_index==_objects.Length)
                {
                    foreach (var obj in _objects)
                    {
                        obj.GetComponent<MeshRenderer>().material.color = Color.green;
                    }
                    return;
                }
               _objects[_index].GetComponent<Rigidbody>().useGravity = true;
            }   
        }   
    }    
}
