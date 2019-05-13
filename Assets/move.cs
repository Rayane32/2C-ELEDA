using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
   [SerializeField] private Image barraVida;
   [SerializeField] private float speed = 0;
   private float horizontal;
   private float vertical;

   void Start()
   {
      
   }

   void Update()
   {
       
       Moviment();
       
        
        
   }
    
    private void OncolliderEnter2D (Collider2D collision)
    {
        if(collision.gameObject.tag == "Vilao")
        {
            barraVida.fillAmount -= 0.33f;
        }
    }

    void Moviment()
   {

       horizontal = Input.GetAxis("Horizontal");
       vertical = Input.GetAxis("Vertical");

       transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
       transform.Translate(Vector3.up * vertical * speed * Time.deltaTime);

    //    if (transform.position.x >= xMax) {
    //        transform.position = new Vector3 (-xMax, transform.position.y);
    //    }

    //     else if (transform.position.y >= yMax) {
    //         transform.position = new Vector3 (-yMax, transform.position.x);
    //     }
       

   }
}
