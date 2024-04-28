# SUT23-Labb3-API

GET/api/Person = Hämtar alla Personer i api:t

GET/api/Person/Interest/{id} = Hämtar information om intressen en person har. Du söker efter personen via Person ID.

GET/api/Person/Links/{id} = Hämtar information om vilka länkar som är kopplade till en vis person. Även här söker du med hjälp av Person ID.

POST/api/Person/AddInterest = Här lägger du till ett nytt intresse för en person. För att göra det använder du Person Id, samt ID:t för intresset. 

POST/api/Person/AddLink = Här lägger du till en länk som är kopplad till både en person och ett intresse, du använder dig av deras Id, sen uppger du en Url länk. 



