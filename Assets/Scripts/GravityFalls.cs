using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFalls : MonoBehaviour
{
    [SerializeField] private Rigidbody _body;
    [SerializeField] private GameObject _floor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _body.useGravity = true;
            _floor.GetComponent<MeshRenderer>().material.color = Color.red;
        }


}


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Floor")
        {
            other.GetComponent<MeshRenderer>().material.color = Color.blue;
            Destroy(this.gameObject);
        }
    }
}
