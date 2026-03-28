@echo off
SETLOCAL ENABLEDELAYEDEXPANSION

REM -------------------------------
REM Config
REM -------------------------------
set "CSProj=C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\Cecil ANSI Utils.csproj"
set "NativeProj=C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\Cecil ANSI Utils Native\Cecil ANSI Utils Native.csproj"

if not exist "%CSProj%" (
    echo ERROR: Project file not found: "%CSProj%"
    exit /b 1
)

if not exist "%NativeProj%" (
    echo ERROR: Project file not found: "%NativeProj%"
    exit /b 1
)

set "CONFIG=%1"
if "%CONFIG%"=="" set "CONFIG=Release"

if /I "%CONFIG%"=="Release" (
    set "OUTPUT_DIR=%~dp0GITHUB RELEASE"
) else (
    set "OUTPUT_DIR=%~dp0GITHUB PRERELEASE"
)

REM Normalize full path
for %%I in ("%OUTPUT_DIR%") do set "OUTPUT_DIR=%%~fI"

REM -------------------------------
REM Clean output root safely
REM -------------------------------
if exist "%OUTPUT_DIR%" rd /s /q "%OUTPUT_DIR%"
mkdir "%OUTPUT_DIR%"

mkdir "%OUTPUT_DIR%\NET"
mkdir "%OUTPUT_DIR%\NATIVE"
mkdir "%OUTPUT_DIR%\NUGET"

set "TMP_ROOT=%OUTPUT_DIR%\_tmp"
mkdir "%TMP_ROOT%"

REM -------------------------------
REM Read TargetFrameworks Native
REM -------------------------------
set "TFsN="
for /f "usebackq tokens=*" %%A in (`type "%NativeProj%" ^| findstr "<TargetFrameworks>"`) do (
    set "line=%%A"
    set "line=!line:<TargetFrameworks>=!"
    set "line=!line:</TargetFrameworks>=!"
    set "line=!line:;= !"
    for %%B in (!line!) do set "TFsN=!TFsN! %%B"
)
set "TFsN=!TFsN:~1!"

REM -------------------------------
REM Read RuntimeIdentifiers Native
REM -------------------------------
set "RIDsN="
for /f "usebackq tokens=*" %%A in (`type "%NativeProj%" ^| findstr "<RuntimeIdentifiers>"`) do (
    set "line=%%A"
    set "line=!line:<RuntimeIdentifiers>=!"
    set "line=!line:</RuntimeIdentifiers>=!"
    set "line=!line:;= !"
    for %%B in (!line!) do set "RIDsN=!RIDsN! %%B"
)
set "RIDsN=!RIDsN:~1!"

if "!TFsN!"=="" set "TFsN=net6.0"
if "!RIDsN!"=="" set "RIDsN=win-x64"

echo TargetFrameworks: !TFsN!
echo RuntimeIdentifiers: !RIDsN!

REM -------------------------------
REM Build Loop Native
REM -------------------------------
for %%F in (!TFsN!) do (
    for %%R in (!RIDsN!) do (
        set "TF_NAME=%%F"
        set "RID_FLAT=%%R"
        set "OUT=!TMP_ROOT!\!TF_NAME!-!RID_FLAT!"

        if exist "!OUT!" rd /s /q "!OUT!"
        mkdir "!OUT!"

        if "%%R"=="win-arm64" (
            echo Publishing NativeAOT: %%F / %%R
            dotnet publish "%NativeProj%" -c "%CONFIG%" -f "%%F" -r "%%R" ^ -o "!OUT!" -p:NoWarn=CS0618 || echo Failed %%F/%%R
            xcopy "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\\Cecil ANSI Utils Native\Hats" "!OUT!\Hats" /E /I /Y
            copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\LICENSE.md" "!OUT!\LICENSE.md"
            copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\README.md" "!OUT!\README.md"
            echo.
            echo ==============================
            echo Native Output Inspection
            echo Framework: %%F
            echo RID: %%R
            echo ==============================
            
            dir "!OUT!"
            
            echo.
            echo ---- Exported Symbols ----
            for %%D in ("!OUT!\*.dll") do (
                echo Inspecting %%~nxD
                dumpbin /EXPORTS "%%D"
            )
            
            echo ==============================
            echo.
            set "ZIP_OUT=%OUTPUT_DIR%\NATIVE\Native-!TF_NAME!-!RID_FLAT!.zip"

            powershell -NoProfile -Command ^ "Compress-Archive -Path '!OUT!\*' -DestinationPath '!ZIP_OUT!' -Force"
        )

        if "%%R"=="win-x64" (
            echo Publishing NativeAOT: %%F / %%R
            dotnet publish "%NativeProj%" -c "%CONFIG%" -f "%%F" -r "%%R" ^ -o "!OUT!" -p:NoWarn=CS0618 || echo Failed %%F/%%R
            xcopy "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\\Cecil ANSI Utils Native\Hats" "!OUT!\Hats" /E /I /Y
            copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\LICENSE.md" "!OUT!\LICENSE.md"
            copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\README.md" "!OUT!\README.md"
            echo.
            echo ==============================
            echo Native Output Inspection
            echo Framework: %%F
            echo RID: %%R
            echo ==============================
            
            dir "!OUT!"
            
            echo.
            echo ---- Exported Symbols ----
            for %%D in ("!OUT!\*.dll") do (
                echo Inspecting %%~nxD
                dumpbin /EXPORTS "%%D"
            )
            
            echo ==============================
            echo.
            set "ZIP_OUT=%OUTPUT_DIR%\NATIVE\Native-!TF_NAME!-!RID_FLAT!.zip"

            powershell -NoProfile -Command ^ "Compress-Archive -Path '!OUT!\*' -DestinationPath '!ZIP_OUT!' -Force"
        )

        rd /s /q "!OUT!"
    )
)

REM -------------------------------
REM Read TargetFrameworks
REM -------------------------------
set "TFs="
for /f "usebackq tokens=*" %%A in (`type "%CSProj%" ^| findstr "<TargetFrameworks>"`) do (
    set "line=%%A"
    set "line=!line:<TargetFrameworks>=!"
    set "line=!line:</TargetFrameworks>=!"
    set "line=!line:;= !"
    for %%B in (!line!) do set "TFs=!TFs! %%B"
)
set "TFs=!TFs:~1!"

REM -------------------------------
REM Read RuntimeIdentifiers
REM -------------------------------
set "RIDs="
for /f "usebackq tokens=*" %%A in (`type "%CSProj%" ^| findstr "<RuntimeIdentifiers>"`) do (
    set "line=%%A"
    set "line=!line:<RuntimeIdentifiers>=!"
    set "line=!line:</RuntimeIdentifiers>=!"
    set "line=!line:;= !"
    for %%B in (!line!) do set "RIDs=!RIDs! %%B"
)
set "RIDs=!RIDs:~1!"

if "!TFs!"=="" set "TFs=net6.0"
if "!RIDs!"=="" set "RIDs=win-x64"

echo TargetFrameworks: !TFs!
echo RuntimeIdentifiers: !RIDs!

REM -------------------------------
REM Build Loop
REM -------------------------------
for %%F in (!TFs!) do (
    for %%R in (!RIDs!) do (

        set "TF_NAME=%%F"
        set "RID_FLAT=%%R"
        set "OUT=!TMP_ROOT!\!TF_NAME!-!RID_FLAT!"

        if exist "!OUT!" rd /s /q "!OUT!"
        mkdir "!OUT!"

        echo Publishing NET: %%F / %%R
        dotnet publish "%CSProj%" -c "%CONFIG%" -f "%%F" -r "%%R" ^ -o "!OUT!" -p:NoWarn=CS0618 || echo Failed %%F/%%R
        copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\LICENSE.md" "!OUT!\LICENSE.md"
        copy /Y "C:\Users\Thinc\Documents\Cecil Libraries\System Core Utils\ANSI Utils\README.md" "!OUT!\README.md"
        set "ZIP_OUT=%OUTPUT_DIR%\NET\!TF_NAME!-!RID_FLAT!.zip"

        powershell -NoProfile -Command ^ "Compress-Archive -Path '!OUT!\*' -DestinationPath '!ZIP_OUT!' -Force"

        rd /s /q "!OUT!"
    )
)

REM Remove temp root completely
rd /s /q "%TMP_ROOT%"

REM -------------------------------
REM Pack NuGet
REM -------------------------------
echo Packing NuGet package...
set "NUGET_OUT=%OUTPUT_DIR%\NUGET"
dotnet pack "%CSProj%" -c "%CONFIG%" -o "!NUGET_OUT!" -p:NoWarn=CS0618 || echo NuGet pack failed

echo.
echo Build completed! Artifacts in:
echo %OUTPUT_DIR%

ENDLOCAL