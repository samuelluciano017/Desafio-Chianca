using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Samuel
{

    public class mensagem : MonoBehaviour
    {
        public GameObject msg;
        public GameObject botoes;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void mostrar()
        {
            botoes.SetActive(false);
            msg.SetActive(true);

        }
        public void voltar()
        {
            botoes.SetActive(true);
            msg.SetActive(false);

        }
    }
}
