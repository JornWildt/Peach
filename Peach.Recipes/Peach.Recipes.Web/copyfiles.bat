xcopy bin\Debug\*.* ..\..\Peach.Website\Peach.Website.Host\bin /D /I /Y /S

mkdir ..\..\Peach.Website\Peach.Website.Host\Areas\Recipes\Views
xcopy Areas\Recipes\Views\*.* ..\..\Peach.Website\Peach.Website.Host\Areas\Recipes\Views\ /D /I /Y /S

mkdir ..\..\Peach.Website\Peach.Website.Host\Areas\Books\Views
xcopy Areas\Books\Views\*.* ..\..\Peach.Website\Peach.Website.Host\Areas\Books\Views\ /D /I /Y /S
