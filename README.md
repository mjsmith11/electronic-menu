# electronic-menu
CS691 Project to create an electronic replacement for restaurant menus

## Development Environment

- Visual Studio 2017
- .NET Framework development kit
- .NET Core development kit

## Database Connection Setup
1. Copy electronic-menu\data_models\Example_ConfigInfo.cs to electronic-menu\data_models\ConfigInfo.cs
1. Edit electronic-menu\data_models\ConfigInfo.cs to contain connection info to a MySQL database that is empty or has tables created for this project. 

## Setting up a new Database
1. Create a blank database on a MySQL server.
1. Grant permissions to the user the application will use `grant all on <new_db>.* to <user_id>;`
1. Copy electronic-menu\data_models\Example_ConfigInfo.cs to electronic-menu\data_models\ConfigInfo.cs and add connection info.
1. Run the web_menu project.
1. The database tables will be created and seeded with data.