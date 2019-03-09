using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intaractive : MonoBehaviour
{
    public LayerMask Vrag;// Загружаем слой врага
    public Transform Center;// Находим цетр телефона
    private bool VragInside;//Проверка на наличее врага в коллайдере
    public float radius;//радиус проверки
    public int cost;//цена способности
    public PlayerControl pc;//название скрипта с маной персонажа
    public VragControl vg; //название скрипта с врага
    private Animator Anime;//переменная для аниматора
    private bool triganime=false;//тригернута ли анимация
    public float RangeAnime;//время анимации=время аудиодорожки
    private float temp;
    public int dealStress;

    void Start()
    {
        
    }
    void OnMouseDown()//запускается по клику на коллайдер
    {
       // temp = RangeAnime;
        //triganime = true;//запускаем анимацию
        //FindObjectOfType<AudioManager>().Play("Название звука из массива");
       if (Physics2D.OverlapCircle(Center.position, radius, Vrag))//Проверка на наличее врага с нужным слоем в цоллайдере
       {
           vg.stress+=dealStress;
       }
        pc.Mana -= cost;
        
    }
    // Update is called once per frame
    //void Update()
    //{
    //    if (triganime)//если анимация тригернута то запускаем таймер
    //    {
    //        temp -= Time.deltaTime;//обратный отсчет
    //        Anime.SetBool("Имя переменноЙ", triganime);//передаем в аниматор то что анимация должна продолжаться
    //    }
    //    if (temp <= 0)//если время вышло то убираем анимационный тригер(прекращаем анимацию)
    //        triganime = false;

    //}
}
