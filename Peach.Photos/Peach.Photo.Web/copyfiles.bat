xcopy bin\Debug\*.* ..\..\Peach.Website\Peach.Website.Host\bin /D /I /Y /S

mkdir ..\..\Peach.Website\Peach.Website.Host\Areas\Photos\Views
xcopy Areas\Photos\Views\*.* ..\..\Peach.Website\Peach.Website.Host\Areas\Photos\Views\ /I /Y /S
