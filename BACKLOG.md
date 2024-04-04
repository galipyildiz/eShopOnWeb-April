- [x] GitHub hesabınızla ilgili repoyu forklayın. Bütün geliştirmenin kendi forkladığınız repo üzerinde olmasını bekliyoruz.
- [X] Admin projesinde Siparişleri listeleyen bir sayfa eklenmesi. Sipariş Tarihi, Sipariş eden kullanıcı, toplam tutar ve Sipariş durumu yeterli. (Admin projesinde blazor kullanılmış ama arayüz tarafında teknoloji kısıtımız yok. Dilerseniz razor pages + standart js de kullanabilirsiniz.)
- [X] Admin projesinde order detayını gösteren bir sayfa veya modal eklenmesi. Bu sayfa veya modal önceki maddede söylenen sayfadan açılmalı. Bu sayfada da sipariş kalemlerin isim, adet ve tutarları göstermeniz yeterli. Aksiyon olarak da sayfanın / modalin altında order ı Approved statetine çekmek için bir buton bulunmalı.
- [X] Sipariş durumu projede db de tutulmuyor. Tüm siparişler default bir "pending" durumunda gösteriliyor. Sipariş durumunu db de tutacak Migrationları ve EF mappingleri yapılmalı.
- [X] Sipariş durumunu değiştirmeye yarayacak servis hazırlanmalı ve sipariş detayı sayfasında kullanılmalı.
- [ ] ~~(Bonus) Unit test yazılması. (değerlendirme şartı değil, ekstra puan olarak değerlendirebilirsiniz)~~

- [ ] Ek olarak Çözümünüzü anlattığınız kısa bir ekran kaydı videosu da çekilmeli. (max 5 dk)

### Start commands

You can configure Visual Studio to start multiple projects, or just go to the PublicApi folder in a terminal window and run `dotnet run` from there. After that from the Web folder you should run `dotnet run --launch-profile Web`. Now you should be able to browse to https://localhost:5001/. The admin part in Blazor is accessible to https://localhost:5001/admin
