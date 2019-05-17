using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int maxLife;
    public int life;
    public GameObject[] spriteHearts;

    void Start() {
        life = maxLife;
        StartCoroutine(LowerUpdate());    
    }

    private void SetHearts(int curLife){
        for(int i = 0; i < spriteHearts.Length; i++){
            if(i > (curLife - 1)){
                Animator anim = spriteHearts[i].GetComponent<Animator>();
                anim.SetTrigger("Broken");
            }
        }
    }

    public void DecrementLife(){
        life--;
        if(life > maxLife){
            life = maxLife;
        }
        else if(life <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator LowerUpdate(){
        for(;;){
            SetHearts(life);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
