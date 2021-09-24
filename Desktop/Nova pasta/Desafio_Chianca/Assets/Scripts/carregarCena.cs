using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Samuel
{
    public class carregarCena : MonoBehaviour
    {
        public Animator anim;
        void Start()
        {

        }
        void Update()
        {

        }

        public void ChangeScene(string cena)
        {
            
            SceneManager.LoadScene(cena);

        }
        public void animar()
        {

            anim.SetTrigger("close");
        }
    }
}