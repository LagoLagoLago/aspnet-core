# Introduction

This is a template to create **ASP.NET Core MVC / Angular** based startup projects for [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents). It has 2 different versions:

1. [ASP.NET Core MVC & jQuery](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core) (server rendered multi-page application).
2. [ASP.NET Core & Angular](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular) (single page application).
 
User Interface is based on [BSB Admin theme](https://github.com/gurayyarar/AdminBSBMaterialDesign).
 
# Download

Create & download your project from https://aspnetboilerplate.com/Templates

# Screenshots

#### Sample Dashboard Page
![主界面](_screenshots/module-zero-core-template-ui-home.png)

#### User Creation Modal
![新建用户](_screenshots/module-zero-core-template-ui-user-create-modal.png)

#### Login Page

![登录页面](_screenshots/module-zero-core-template-ui-login.png)

# Documentation

* [ASP.NET Core MVC & jQuery version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core)
* [ASP.NET Core & Angular  version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular)

# License

[MIT](LICENSE).

必备条件
nuget 配置
首先设置开发环境，打开nuget程序包管理器，添加一个nuget源。
![配置Nuget源](_screenshots/nugetConfig.png)
https://dotnet.myget.org/F/aspnetcore-dev/api/v3/index.json
如图所示： Nuget Option 然后生成解决方案。

数据库的生成
选择EntityFrameworkCore层，作为默认 Generator Data Base 执行
![生成数据库命令](_screenshots/updateDatabase.png)
update-database
