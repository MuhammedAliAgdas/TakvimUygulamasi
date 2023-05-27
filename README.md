# Takvim Uygulaması
### Uygulamanın Amacı
Geliştirdiğimiz takvim uygulaması sayesinde kullanıcılar; kendi kişisel takvimlerini oluşturmak için uygulamaya kayıt olabilir, katılacakları etkinlikleri kişisel takvimlerine kaydedebilir, kaydettikten sonra güncelleyebilir, silebilir ve eğer alarm ekle özelliğini kullanmışlar ise etkinliğin günü geldiğinde uygulamanın kendilerine sesli hatırlatma yapmasını sağlayabilirler. 
### Uygulamanın Özellikleri
1. **Kullanıcı Kaydı ve Giriş**:Kullanıcılar uygulamaya kayıt olabilir veya giriş yapabilirler.Kaydı olmayan kullanıcılar gerekli kişisel bilgilerini girerek uygulamaya kayıt olabilir.
2. **Olay Ekleme**:Kullanıcılar takvimlerine yeni olaylar ekleyebilir.Olay  hakkındaki ayrıntıları belirtebilir. 
3. **Olay Silme ve Güncelleme**:Kullanıcılar tanımladıkları olayların bütün özelliklerini güncelleyebilir veya silebilirler.
4. **Alarmlar**:Kullanıcılar tanımladıkları herhangi bir olay için alarm oluşturabilir.Alarmlar önceden tanımlanmış etkinlikleri günü geldiğinde sesli bir şekilde kullanıcıya hatırlatır.
### Uygulamanın Kullanımı
- Uygulama açıldığında kaydınız varsa *kullanıcı adı* ve *şifre* bilgilerinizi girebilirsiniz.Uygulamanın SQL ile kurduğu veritabanı bağlantısı sayesinde giriş işlemi gerçekleşecektir.
- Kaydınız yoksa "Kayıt ol" butonuna tıklayarak kayıt ekranına gidebilirsiniz.Kayıt ekranında istenen kişisel bilgileri girerek veritabanına bilgilerinizi gönderirsiniz ve kayıt işleminiz gerçekleşir.Tekrardan giriş ekranına gelerek *kullanıcı adı* ve *şifre*niz ile giriş yapabilirsiniz.
- Giriş işlemi gerçekleştikten sonra gün,ay ve yıl seçenekleriyle takvim üzerinde gezinebilirsiniz.
- "Olay Ekle" butonuna tıklayarak eklemek istediğiniz olayın *tarih*,*saat*,*tanım* ve *açıklama* bilgilerini girip olay ekleme işlemini gerçekleştirebilirsiniz.
- Eklenen olayı güncelletip silebilirsiniz.
- Hatırlatılmasını istediğiniz herhangi bir olay için alarm tanımlaması yapabilirisiniz.
### Lisans
Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

