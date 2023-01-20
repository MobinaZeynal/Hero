using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Transform transform;
    public float speed = 1.5f;

        public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3 (speed * Time.deltaTime , 0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,-47),rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3 (speed * Time.deltaTime , 0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,47),rotationSpeed * Time.deltaTime);
        }
        if(transform.rotation.z !=0){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,0),rotationSpeed * Time.deltaTime);
        }

        if(transform.position.x < -1.98f) {
         transform.position = new Vector3 (-1.98f,transform.position.y,transform.position.z);
        }
         if(transform.position.x > 1.98f) {
         transform.position = new Vector3 (1.98f,transform.position.y,transform.position.z);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
     Time.timeScale = 0;
     Debug.Log("Barkhord!!");
    }
}
