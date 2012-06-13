xcopy bin\Debug\*.* ..\..\Peach.Website\Peach.Website.Host\bin /D /I /Y /S

mkdir ..\..\Peach.Website\Peach.Website.Host\Areas\Profiles\Views
xcopy Areas\Profiles\Views\*.* ..\..\Peach.Website\Peach.Website.Host\Areas\Profiles\Views\ /I /Y /S
