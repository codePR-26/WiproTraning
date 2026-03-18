@echo off
echo ========================================
echo    NestInn Tailwind Frontend Setup
echo ========================================
echo.
echo Step 1: Installing dependencies (includes Tailwind CSS)...
call npm install
echo.
echo Step 2: Starting development server on port 4201...
echo.
echo Open http://localhost:4201 in your browser
echo.
call ng serve --port 4201
