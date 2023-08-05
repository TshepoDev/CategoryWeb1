*Problem:*
The provided code aims to solve the problem of creating a database table in an ASP.NET Core application using Entity Framework Core. Specifically, it addresses the issue of generating a table named "Categories" with the columns Id, Name, DisplayOrder, and CreatedTime.

*Problem-Solving Approach:*

Model Creation: The code defines a Category class within the CategoryWeb.Models namespace, which serves as the model for the database table. It includes properties such as Id, Name, DisplayOrder, and CreatedTime, representing the structure of the table.

Data Annotations: To configure the Category class for Entity Framework Core, Data Annotations are utilized. The [Key] attribute is applied to the Id property to indicate that it is the primary key for the table.

Default Value: The CreatedTime property is initialized with a default value of DateTime.Now, ensuring that it is automatically set to the current date and time when a new record is inserted into the table.

Migration and Database Update: To apply the changes to the database, Entity Framework Core migrations are used. The Add-Migration command generates a migration with the necessary changes based on the model class. Subsequently, the Update-Database command applies the migration, creating the "Categories" table in the database specified in the DbContext.
