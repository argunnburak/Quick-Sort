Burak Arğun 2020

# Quick-Sort
Quick Sort, "böl ve yönet" 

# Quick Sort Sıralama Algoritması

Bu proje, C# programlama dilinde Quick Sort sıralama algoritmasını uygulayan bir sınıf içerir.

## Kullanım

Quick Sort algoritmasını kullanmak için aşağıdaki adımları takip edebilirsiniz:

1. `Quick` sınıfını projenize ekleyin.

2. `ISorter` arayüzündeki `Execute` metodunu kullanarak Quick Sort'u başlatın.

    ```csharp
    int[] arrayToSort = { /* your array elements */ };
    Quick quickSorter = new Quick();
    quickSorter.Execute(arrayToSort);
    ```

## Katkıda Bulunma

Eğer projeye katkıda bulunmak istiyorsanız, lütfen aşağıdaki adımları takip edin:

1. Fork (çatallama) yapın.
2. Yeni bir branch (dal) oluşturun (`git checkout -b feature/branch-name`).
3. Değişikliklerinizi commit edin (`git commit -m 'Add some feature'`).
4. Branch'inizi push edin (`git push origin feature/branch-name`).
5. Pull request (çekme isteği) oluşturun.

