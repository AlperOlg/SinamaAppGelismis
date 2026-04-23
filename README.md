# SinamaAppGelismis
Bu proje, modern yazılım geliştirme prensipleri ve kurumsal mimari yaklaşımları kullanılarak geliştirilmiş kapsamlı bir sinema yönetim sistemidir. CRUD işlemlerinin ötesinde, asenkron programlama ve bağımlılık yönetimi gibi ileri seviye teknikleri barındırır.

--Kullanılan Teknolojiler ve Mimariler:
  Proje, N-Katmanlı Mimari üzerine inşa edilmiştir:
    *UI: Windows Forms & Guna UI2.
    *Business: Service/Manager katmanı.
    *DataAccess: Entity Framework Core, MSSQL Server, Code First yaklaşımı.
    *Entities: Model Classlar

--Teknik Özellikler:
*Dependency Injection: DependencyInjection ile servis bağımlılıklarının yönetimi.
*Generic Repository Pattern: Kod tekrarını minimize eden, esnek veri erişim altyapısı.
*Async/Await: Tüm veritabanı ve UI operasyonlarında asenkron çalışma prensibi.
*SOLID & OOP: Sorumlulukların ayrılması, arayüz tabanlı geliştirme ve temiz kod standartları.
*Event-Driven UI: UserControl'ler arası iletişimde event tabanlı mimari.

--Uygulama Özellikleri
*Film, Oyuncu, Yönetmen ve Seans Yönetimi: Tüm varlıklar üzerinde tam CRUD desteği.
*Biletleme Sistemi: Dinamik salon ve koltuk yönetimi.
*Kullanıcı Yetkilendirme: Kayıt olma ve giriş yapma.
*UI/UX: Dinamik paneller, özel geçiş ekranı ve akıcı navigasyon.
