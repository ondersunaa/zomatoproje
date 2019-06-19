# zomatoproje
Asp.Net Core MVC ile yap�lm�� bir uygulamad�r ve Code First yakla��m� kullan�lm��t�r. Uygulamamda T�rkiye�deki �ehirlerde bulunan caf�, bar restorant vb. sekt�rlerde olan i�letmelerin kendi profillerini y�netti�i ve men�lerini payla�t��� bir uygulama. Projemde ama�lad���m ise, benzer uygulamalarda g�rd���m a��kl�k olan, ma�azalar�n kendi profillerini d�zenleyerek m��terilere her an g�ncel bilgiler sunabilmesini sa�lamak. Web sitemi Bootstrap 4 ile haz�rlanm�� bir Template giydirdim.

Kullan�lan Teknolojiler: C#, Visual Studio, Asp.net Core, MVC, CSS3, HTML5, Razor

Uygulamay� �al��t�rabilmeniz i�in:
1-) Visual Studio y�kl� olmas� gerek.
2-) MS Sql Server y�kl� olmas� gerek.
3-) Uygulman�n startup'daki connectionstring'ini ayarlaman�z gerek.
4-) Uygulmamda code first yakla��m� ile yap�ld��� i�in ve identity oldu�undan dolay� iki farkl� context i�in migration yapman�z gerek.

cmd ekran�nda:
1-) dotnet ef migrations add MigrationIsmi --context Context
2-)dotnet ef database update --context Context
3-) dotnet ef migrations add MigrationIsmi --context ApplicationIdentityDbContext
4-)dotnet ef database update --context ApplicationIdentityDbContext
komutlar�n� yazman�z gerekmektedir.