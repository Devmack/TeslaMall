# TeslaMall

1. Reservations period has limit to prevent booking for abstract time range (ex. 10000 years), also period setters have internal validation to prevent invalid data order
2. Reservations must be confirmed to lock car for renting
3. Reservations must be paid off to be confirmed
4. I've decided to go with persistency layer using entity framework (code first approach) with msssql 
5. Access to data is done via repository design pattern to enable easy data source switching (ex. from mssql to mongo) 
6. Custom dependecies within DI Container were moved to dedicated extension methods to clean up program.cs structure
7. Implement DTO layer to ensure safety of database content with basic attribute validation
8. To speed up and ease domain model to dto model conversion Automapper was used