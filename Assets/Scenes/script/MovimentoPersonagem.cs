using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour
 {
    
   public float speed = 0;
   float horizontal;
   float vertical;

   void Start()
   {
      
   }

   void Update()
   {
       
       Moviment();
       

   }
   
   void Moviment()
   {

       horizontal = Input.GetAxis("Horizontal");
       vertical = Input.GetAxis("Vertical");

       transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
       transform.Translate(Vector3.up * vertical * speed * Time.deltaTime);

   }
}


