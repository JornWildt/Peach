dir
xcopy bin\Debug\*.* ..\..\Peach.Website\Peach.Website.Host\bin /D /I /Y /S

mkdir ..\..\Peach.Website\Peach.Website.Host\Areas\Recipes\Views
xcopy Areas\Recipes\Views\*.* ..\..\Peach.Website\Peach.Website.Host\Areas\Recipes\Views\ /D /I /Y /S