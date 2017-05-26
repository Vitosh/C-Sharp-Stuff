***Entity Framework Basics***

https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx

*Getting SQL Script:*
Run the Update-Database -Script -SourceMigration: $InitialDatabase -TargetMigration: AddPostAbstract command in Package Manager Console

*Migrate to a Specific Version (Including Downgrade)*
Run the Update-Database –TargetMigration: AddBlogUrl command in Package Manager Console.
This command will run the Down script for our AddBlogAbstract and AddPostClass migrations.
If you want to roll all the way back to an empty database then you can use the Update-Database –TargetMigration: $InitialDatabase command.

*Add-Migration* will scaffold the next migration based on changes you have made to your model since the last migration was created
*Update-Database* will apply any pending migrations to the database
