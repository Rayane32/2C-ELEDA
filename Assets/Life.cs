using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public int life;
    public GameObject[] spriteHearts;

    void Start() {
        StartCoroutine(LowerUpdate());    
    }

    public void SetHearts(int curLife){
        for(int i = 0; i < spriteHearts.Length; i++){
            if(i > (curLife - 1)){
                Animator anim = spriteHearts[i].GetComponent<Animator>();
                anim.SetTrigger("Broken");
            }
        }
    }

    IEnumerator LowerUpdate(){
        for(;;){
            SetHearts(life);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
