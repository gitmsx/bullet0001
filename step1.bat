@echo off
if not exist ".gitignore" goto :fail_message
echo.
echo    GIT ignore GOOD 
echo.
echo    Exiting...

echo "# butterfly003" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/gitmsx/bullet0001.git
git push -u origin main


goto finished
:fail_message
echo.
echo    Unfortunately GIT ignore not found
echo.
echo    Exiting...
timeout 1 >nul
goto finished        

rem    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:finished
exit