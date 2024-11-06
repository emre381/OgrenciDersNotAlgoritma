### Öğrenci Veritabanı Konsol Uygulaması

Bu uygulama, bir bölümde okuyan öğrencilerin bilgilerini kaydedip analiz yapmayı sağlar. Kullanıcıdan her bir öğrenci için sınıf (1-4), genel not ortalaması (0-100) ve mezun olduğu lise bilgileri istenir. Uygulama, bu bilgileri aldıktan sonra her lise ve sınıf için detaylı analiz yaparak sonuçları kullanıcıya sunar.

---

### Özellikler

1. **Veri Girişi**:
   - Kullanıcıdan her bir öğrenci için sınıf, genel not ortalaması ve lise bilgileri alınır.
   - Bilgi girişi sırasında kullanıcı, başka öğrenci eklemek isteyip istemediğini belirtebilir.
   
2. **Lise Bazlı Analiz**:
   - Her liseden mezun olan öğrencilerin sayısı ve not ortalamaları hesaplanır.
   - Her lise için sonuçlar konsola yazdırılır.

3. **Sınıf Bazlı Analiz**:
   - Her sınıfta bulunan öğrenci sayısı hesaplanır.
   - Öğrencilerin not ortalamaları 10 puanlık aralıklara göre yüzdeler halinde dağıtılır ve konsola yazdırılır.

---

### Kullanım

1. **Uygulamayı Başlatın**:
   - Konsol ekranından programı çalıştırın.

2. **Öğrenci Bilgilerini Girin**:
   - Ekranda sırasıyla istenen bilgileri (sınıf, not ortalaması ve lise) girin.
   - Her öğrenci bilgisini girdikten sonra, `Başka öğrenci var mı? (e/E/h/H):` sorusuna yanıt verin:
     - **e/E**: Yeni bir öğrenci eklemek için devam edin.
     - **h/H**: Veri girişini sonlandırın ve analiz sonuçlarını görüntüleyin.

3. **Sonuçları Görüntüleyin**:
   - Lise bazında öğrenci sayıları ve not ortalamalarını, ardından sınıf bazında öğrenci sayıları ve not yüzdelerini konsol ekranında görüntüleyin.

---

### Örnek Çalışma

Kullanıcı girdileri:

```
Sınıf (1-4): 3
Genel Not Ortalaması (0-100): 85
Mezun Olduğu Lise: Anadolu Lisesi
Başka öğrenci var mı? (e/E/h/H): e
Sınıf (1-4): 2
Genel Not Ortalaması (0-100): 70
Mezun Olduğu Lise: Fen Lisesi
Başka öğrenci var mı? (e/E/h/H): h
```

Konsol Çıktısı:

```
Lise Bazlı Öğrenci Sayıları ve Not Ortalamaları:
Lise: Anadolu Lisesi, Öğrenci Sayısı: 1, Not Ortalaması: 85.00
Lise: Fen Lisesi, Öğrenci Sayısı: 1, Not Ortalaması: 70.00

Sınıf Bazlı Öğrenci Sayıları ve Not Dağılımları:

Sınıf: 3, Öğrenci Sayısı: 1
Not Aralığı 80-89: %100.00

Sınıf: 2, Öğrenci Sayısı: 1
Not Aralığı 70-79: %100.00
```

---

### Geliştirme ve İyileştirme Önerileri

- **Veri Doğrulama**: Girilen sınıf ve not değerleri için geçerli aralıkları kontrol eden ek güvenlik önlemleri eklenebilir.
- **Veri Saklama**: Girilen verilerin dosyaya kaydedilmesi ve daha sonra okunması sağlanabilir.
- **Gelişmiş Analiz**: Not ortalamalarına göre öğrenci sıralaması veya en yüksek ve en düşük notu gösteren ek analizler yapılabilir.

--- 
