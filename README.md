Bu proje, araç kayıtlarını yönetmek için bir API sağlar. API, araçları listeleme, ekleme, güncelleme ve silme gibi temel işlemleri destekler.

Kullanım
API'yi kullanmak için aşağıdaki temel işlemleri gerçekleştirebilirsiniz:

Araçları Listeleme: /api/cars endpointi üzerinden tüm araçları listeleyebilirsiniz.
Araç Ekleme: /api/cars endpointi üzerinden yeni bir araç ekleyebilirsiniz.
Araç Güncelleme: /api/cars/{id} endpointi üzerinden belirli bir aracı güncelleyebilirsiniz.
Araç Silme: /api/cars/{id} endpointi üzerinden belirli bir aracı silebilirsiniz.
API hakkında daha fazla bilgi için belgelere göz atabilirsiniz.

Başlangıç
API'yi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

Proje deposunu klonlayın:
bash
Copy code
git clone https://github.com/kullaniciadi/proje.git
Proje klasörüne gidin:
bash
Copy code
cd proje
Projeyi çalıştırın:
arduino
Copy code
dotnet run
