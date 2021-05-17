using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class ExitButton : MonoBehaviour
    {
        public GameObject ButtonMenu;
        void Start()
        {
            ButtonMenu.SetActive(true);
        }
        public void MenuAtivator()
        // Update is called once per frame
        //void Update()
        {
            ButtonMenu.SetActive(false);
        }
    }
   
