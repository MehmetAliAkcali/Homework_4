GC'yi bir anolojiyle açıklayalım ve bir masanın belleğimiz olduğunu hayal edelim. Biz programlarımızı çalıştırdığımızda, bu masanın üzerinde bir sürü nesne oluşturuyoruz. Bu nesneler, programımızın kullandığı veriler, değişkenler vesaire.

Bazı nesneleri kullanıp işimiz bittiğinde, artık onlara ihtiyacımız kalmıyor. Mesela bir hesaplama yaptık, sonucu bir değişkene kaydettik ve artık o değişkenle işimiz bitti. İşte bu noktada Garbage Collector devreye giriyor.

Garbage Collector, masamızdaki temizlikçi gibi düşünebiliriz. O, sürekli masayı kontrol ediyor ve artık kullanılmayan, işi bitmiş nesneleri tespit ediyor. Tıpkı bizim işimiz bitince çöpe attığımız kağıtlar gibi.

 GC bu nesneleri bulduktan sonra onları masadan kaldırıyor, yani belleği temizliyor. Böylece belleğimizde gereksiz yere yer kaplayan nesnelerden kurtulmuş oluyoruz ve yeni nesneler için yer açılıyor.

Garbage Collector'ın en önemli özelliklerinden biri  bu temizliği otomatik olarak yapması. Bizim elimizle tek tek nesneleri silmemize gerek kalmıyor. Tıpkı evdeki robot süpürge gibi işini kendi kendine hallediyor.

Bu otomatik bellek yönetimi, programlarımızın daha verimli çalışmasını sağlıyor .Belleğimiz sürekli temiz tutuluyor ve yeni nesneler için yer açılıyor. Eğer Garbage Collector olmasaydı belleğimiz zamanla gereksiz nesnelerle dolardı ve programlarımız yavaşlar, hatta çökerdi.

Özetle, Garbage Collector, C#'ta otomatik bellek yönetimini sağlayan ve artık kullanılmayan nesneleri temizleyerek belleğimizi verimli kullanmaya yarayan bir sistemdir.

Şimdi TEKNİK olarak bir fikir sahibi olmaya çalışalım.

GC ilk olarak yönetilen yığın (managed heap) denilen bir yeri tarıyor. Burada nesnelerin ömrüne göre jenerasyonlara ayrılmış bölümler var. Yeni nesneler ilk başta 0. jenerasyonda oluyor, sonra ömürleri uzadıkça diğer jenerasyonlara geçiyorlar. GC de daha çok yeni nesnelerin olduğu yerleri temizliyor, çünkü genellikle onlar daha çabuk işe yaramaz hale geliyor.

GC, nesneleri temizlerken referans takibi yapıyor. Yani bir nesneye artık hiçbir yerden erişilemiyorsa, o nesneyi çöp olarak işaretleyip siliyor. Bu temizleme işlemi de otomatik olarak belli zamanlarda ya da belleğimiz azaldığında gerçekleşiyor.

Yalnız bu GC bazen programımızın çalışmasını kısa süreliğine durdurabiliyor, buna 'garbage collection pauses' diyorlar. Bir de 'yönetilmeyen kod' denilen bir şey var, mesela başka dillerden gelen kodlar. Onların belleğini GC temizlemiyor, onu bizim elimizle yönetmemiz gerekiyor. Bu konuda tecrübem yok fakat kısacası bilmemiz gereken şey GC bu durumlarda otomatik temizlemiyor, manuel halletmemiz gerekiyor.

Son...
