using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InstantiateOfBook : MonoBehaviour
{
    //Необходимо установить Physics Raycaster на основную камеру
    public GameObject bookMenu;
    public GameObject writer1;
    public GameObject writer2;
    public GameObject writer3;
    public GameObject writer4;
    public GameObject writer5;
    public GameObject writer6;
    public GameObject writer7;
    public GameObject writer8;
    public GameObject writer9;
    public GameObject writer10;

    //Дополнительные листы
    public GameObject writer1a;
    public GameObject writer2a;
    public GameObject writer3a;
    public GameObject writer4a;
    public GameObject writer5a;
    public GameObject writer6a;
    public GameObject writer7a;
    public GameObject writer8a;
    public GameObject writer9a;
    public GameObject writer10a;

    //Кнопка добавления листика
    public GameObject ButtonPlus;

    //Объект и скрипт, где находятся необходимые переменные
    public GameObject ControlerOfBook;
    public AddList addList;

    public void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            bookMenu.SetActive(true);

            writer1.SetActive(true);
            writer2.SetActive(true);
            writer3.SetActive(false);
            writer4.SetActive(false);
            writer5.SetActive(false);
            writer6.SetActive(false);
            writer7.SetActive(false);
            writer8.SetActive(false);
            writer9.SetActive(false);
            writer10.SetActive(false);

            writer1a.SetActive(false);
            writer2a.SetActive(false);
            writer3a.SetActive(false);
            writer4a.SetActive(false);
            writer5a.SetActive(false);
            writer6a.SetActive(false);
            writer7a.SetActive(false);
            writer8a.SetActive(false);
            writer9a.SetActive(false);
            writer10a.SetActive(false);

            if (addList.l12 == true)
                ButtonPlus.SetActive(false);
        }
}

    // Start is called before the first frame update
    void Start()
    {
        addList = ControlerOfBook.gameObject.GetComponent<AddList>();
        bookMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
