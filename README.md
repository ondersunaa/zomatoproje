# zomatoproje
Asp.Net Core MVC ile yapýlmýþ bir uygulamadýr ve Code First yaklaþýmý kullanýlmýþtýr. Uygulamamda Türkiye’deki þehirlerde bulunan café, bar restorant vb. sektörlerde olan iþletmelerin kendi profillerini yönettiði ve menülerini paylaþtýðý bir uygulama. Projemde amaçladýðým ise, benzer uygulamalarda gördüðüm açýklýk olan, maðazalarýn kendi profillerini düzenleyerek müþterilere her an güncel bilgiler sunabilmesini saðlamak. Web sitemi Bootstrap 4 ile hazýrlanmýþ bir Template giydirdim.

Kullanýlan Teknolojiler: C#, Visual Studio, Asp.net Core, MVC, CSS3, HTML5, Razor

Uygulamayý çalýþtýrabilmeniz için:
1-) Visual Studio yüklü olmasý gerek.
2-) MS Sql Server yüklü olmasý gerek.
3-) Uygulmanýn startup'daki connectionstring'ini ayarlamanýz gerek.
4-) Uygulmamda code first yaklaþýmý ile yapýldýðý için ve identity olduðundan dolayý iki farklý context için migration yapmanýz gerek.

cmd ekranýnda:
1-) dotnet ef migrations add MigrationIsmi --context Context
2-)dotnet ef database update --context Context
3-) dotnet ef migrations add MigrationIsmi --context ApplicationIdentityDbContext
4-)dotnet ef database update --context ApplicationIdentityDbContext
komutlarýný yazmanýz gerekmektedir.