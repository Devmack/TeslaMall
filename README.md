# Tesla mall 
Project created for the recruitment process. 
Tiny web app that enables user to rent a Tesla car at exotic mallorca for a given period of time. 

## How to run
Backend was written in .net 8.0 and utilize some of its features like collection literal. 
I used template to store backend .net api and react + vite at one solution, quickest way to run is to trigger project from visual studio 22, which was used as a primary code editor

Persistency is based on ORM - ef core and it requires MSSQL server to apply migration (forced to do at start) and seed with demo data

## DevLog - not chronological 
## To be discussed, but my overal development strategy was to start from backend: identify domain models and persistency layer, then wrap and expose domain layer to the web. Next part was oriented on creating mock front. 

**important!** **To cancel reservation for any reservation email enter "1234"  as a code (its hardcoded value, that can be replaced later on with some custom solution)**. It is simple system to prevent anyone who knows your adress to see and cancel your rented car. 
Payment gate is simplest possible stub - to pay enter any value. Later on it can be replaced with custom payment gate 

1. Reservations period has limit to prevent booking for abstract time range (ex. 10000 years)
2. Reservations first is confirmed, later on paid - I programmed user path that between confirmation and payment there is no "time in-between" either you pay or reject. 
4. I've decided to go with persistency layer using entity framework (code first approach) with msssql 
5. Access to data is done via repository design pattern to enable easy data source switching (ex. from mssql to mongo) 
6. Custom dependencies within DI Container were moved to dedicated extension methods to clean up program.cs structure
7. Implement DTO layer to ensure safety of database content with basic attribute validation
8. To speed up and ease domain model to dto model conversion Automapper was used
9. I've decided to use MaterialUI as a main UI library to speed up development and ensure mobile friendly design
10. I've added description as a additional contextual info for every rental location 
11. To match requirement about renting and cancelling rent I've assumed that rent must be assigned to a someone - so i've added userreservation entity to enable ability to rent via email and further on unrent. to secure unwanted unrenting user gets assigned personal key that will be required for checking reservation and also cancelling.
12. Implement global error handling via middleware to reduce code redundancy in controllers and centralize custom errors returns 
13. Rental process lock. User cannot rent already rented car. 
14. I've decided that there can be only one reservation per email. Multiple reservation would engage more redundant logic.
15. Reservations cannot be done with dates inverted (end earlier than start) 
16. Reservations cannot be done with retroactive dates
17. Introduced payment abstraction to demonstrate idea of inserting different payment gate implementation 
18. Reservation is closed by pointing out return place (can be different as a starting one)


I hope you guys enjoyed the program! Looking forward to hearing from you
Dominik