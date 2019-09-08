using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : Singleton<BookManager>
{
    [SerializeField] private GameObject mainBookPage;
    [SerializeField] private List<Book> books = new List<Book>();

    [SerializeField] private Sprite[] bookSprites_0;
    [SerializeField] private Sprite[] bookSprites_1;
    [SerializeField] private Sprite[] bookSprites_2;
    [SerializeField] private Sprite[] bookSprites_3;
    [SerializeField] private Sprite[] bookSprites_4;
    [SerializeField] private Sprite[] bookSprites_5;
   


    // Start is called before the first frame update
    void Start()
    {
        AssignBooks();
    }

    public void ChooseBookToOpen(int bookIndex){
        mainBookPage.SetActive(true);
        

        Sprite[] tempBookSprites = null;
        switch (bookIndex)
        {
            case 0:
                tempBookSprites = bookSprites_0;
                break;
            case 1:
                tempBookSprites = bookSprites_1;
                break;
            case 2:
                tempBookSprites = bookSprites_2;
                break;
            case 3:
                tempBookSprites = bookSprites_3;
                break;
            case 4:
                tempBookSprites = bookSprites_4;
                break;
            case 5:
                tempBookSprites = bookSprites_5;
                break;
            default:
                tempBookSprites = bookSprites_0;
                break;
        }

        //
        BookPageManager.Instance.SetBookSprites(tempBookSprites);

        //Open Book
        BookPageManager.Instance.OpenBook(books[bookIndex], bookIndex);
    }

    void AssignBooks(){

        books.Add(new Book("ABC Ayo Belajar Membaca",
         "Kumpulan bentuk-bentuk huruf Alphabet beserta contohnya" ,
         "Nasir Nugroho", "Teman Januar", "5-10", "27", "5-13", "PIKO")
         );

        books.Add(new Book("Belajar Sholat Bersama Ali",
         "Buku belajar sholat, mengenalkan anak gerakan-gerakan dasar sholat" ,
         "Teman Januar", "Teman Januar", "5-10", "13", "5-13", "Teman Januar")
         );
    }

    public Book GetBook(int bookIndex){
        return books[bookIndex];
    }
}
