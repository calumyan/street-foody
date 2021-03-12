# street-foody

Street-foody is a responsive website that introduces travelers to a substantial part of Asian culture - street food, and allows street vendors to have a dedicated online space. For our first version, we'll focus on Saigon (or Ho Chi Minh City)'s street food.


## Project Vision and Goals

### Problems to solve

People have trouble finding street vendors based on name and food type if they’ve never been to Vietnam. We also want to build a place for local people and even foreigners to know about the prices and ratings before they arrive at the vendors to help them make better choices. 

### Goals

1. Gives users a breif intro to Vietnamese street food and food categories 
2. Allows users search  a place to eat based on street vendor’s name and food type
3. Allows users sort and filter through street food based on price tags and ratings
4. Allows street vendors access to online advertising by submitting forms through a url to a google form (in the future there will be a “real” server based form to fill out)
5. Allows users to view each vendor's information (open hours, menu, location from a map, etc.)





## Before you start

1. Make sure either Visual Studio or Visual Studio Code is installed.
2. Make sure .NET Core is installed, if you haven't, download [here](https://dotnet.microsoft.com/download). Make sure you download .NET Core of version 5.0 or later.
3. If you want get to know how our database is structured or want to view our existing data, download pgAdmin [here](https://www.pgadmin.org) and download PostgreSQL 10.x [here](https://postgresapp.com/downloads.html)
4. Download or clone this street-foody repository by either go to the green "download code" button and click "download zip" or copy the link of this repository to your editor and clone from github



## For Users

* To run the project, for VSCode, go to the terminal and run <code> dotnet run </code> and go to https://localhost:5001 to see the web pages. For Visual Studio,  click the run button at the top of the Visual Studio. 

* To build the project, run <code> dotnet build </code> in the terminal

* There is a pretty complete guide on how to use our app on the handbook page, check it out! 



## Installation For Developers 


### Running

If running on Visual Studio Code, go to the terminal and run  <code> dotnet build </code>
If using Visual Studio, 

### Build

To build our app (especially if you run into issues and want to see what error occurs), 
if building on Visual Studio Code,go to the terminal run <code> dotnet build </code>

### Testing

To test our  , .


 

## References 

Our references mostly come from [Microsoft documentation for asp.net core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0).
We also referenced [this meidum article](https://medium.com/@agavatar/webapi-with-net-core-and-postgres-in-visual-studio-code-8b3587d12823) for setting up postgresql database]


## a small issue 

The website is loading pretty slow right now, so you may have to wait for a few seconds for the it to direct to another page

We only have a limited amount of data from our friends right now so some of the food categories don't match with any of the vendors. If you click on the button on some of the cards in the handbook it's likely you won't get a result.


