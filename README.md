# Hello World in C# 

**Beispiel für ein Batch-Skript*+

echo off
echo # Hello World in C# >> README.md
(
echo # Visual Studio-spezifische Dateien
echo .vs/
echo.
echo # Binärdateien und Build-Artefakte
echo bin/
echo obj/
echo.
echo # Batch-Skripte
echo *.bat
) >> .gitignore
echo on
git init
git add .
git commit -m "Initial Commit"
git branch -M main
git remote add origin https://github.com/mikeCloudLiner/HelloWorld_CS.git
git config http.proxy "http://XXX.XXX.XXX.XX:8080"
git config https.proxy "http://XX.XXX.XXX.XX:8080"
git push -u origin main
pause
