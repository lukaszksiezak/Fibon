# Fibon
Demo of dotnet core application using docker hosted rabbitmq service and simple calculation on server site, to simulate delayed response from server.

*How to start:*
1. Restore all dependencies:

        dotnet restore
2. Build application:

        dotnet build
3. Start docker hosted rabbitmq instance:

        docker run -d --hostname my-rabbit --name some-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
4. Make sure rabbit is working:

        docker ps
5. Run Fibon.Api (port 5000) and Fibon.Service (port 5050) using the command inside directories:

        dotnet run
6. In your browser check if both services are running:

        localhost:5000 and localhost:5050        
6. Using postman or any other tool make a POST call:

        localhost:5000/fibonacci/5
7. Make GET call to read the result:

        localhost:5000/fibonacci/5
8. Make GET call to read all the items in cached storage:

        localhost:5000/fibonacci/queue

9. In main directory run the command to run tests:

        dotnet test
