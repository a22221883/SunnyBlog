# 我的 ASP.NET Core MVC 專案

## 簡介
該專案展示了一個簡單的 web 應用程序，使用 ASP.NET Core MVC 框架構建。

## 功能
- 用戶可以新增文章分類
- 用戶可以新增文章

## 目錄結構
- `/Controllers` - 包含控制器文件
- `/Models` - 包含數據模型文件
- `/Views` - 包含視圖文件

## 系統需求
- .NET SDK 版本：5.0
- EF Core 版本：5.0.17
- Visual Studio 2019 或Visual Studio 2022

## 如何編譯和運行

1. **複製專案：**
- 從 GitHub 上複製此專案到您的開發工具。
   
2. **同步localDB：**
- dotnet ef migrations list
- dotnet ef database update

- *若找不到專案，請指定專案位置
- 例如：
- dotnet ef migrations list --startup-project "C:\Visual Studio 2022 Work" -> 檔案位置請自行替換
- dotnet ef database update --startup-project "C:\Visual Studio 2022 Work Project\SunnyBlog\SunnyBlog" -> 檔案位置請自行替換
