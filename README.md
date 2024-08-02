# EmrysSerenArt
An updated website for the Artist Emrys Seren.

## Overview

The project is my capstone project for CODE:You. This project is a blog for the artist Emrys Seren. Patrons and fans can comment on Emrys Seren's blog posts. If time allows, I will also convert the rest of the original Emrys Seren website (https://github.com/CosmicIdes/EmrysSeren) to Blazor/MudBlazor.

## Features Utilized for the project

  | Feature        | Description                           |
  |----------------|---------------------------------------|
  | Blazor | Front end UI was made using Blazor and MudBlazor |
  | Entity Framework | The data layer is abstracted with EF and a Repository Pattern |
  | Make your application a CRUD API | Can add, edit, and delete blog entries and comments. Username will be part of the API payload.|
  | 2 or more tables (entities) in your application | BlogPost table, CommentPost table, User table |
  | Create 3 or more Unit Tests | Will have at least three unit tests |
  | Regular expression (regex) | Email for the user will be validated to ensure it is in an "a@a.com" format |

## Getting Started

To run this project, follow these steps:

1. Clone the repository: `git clone https://github.com/CosmicIdes/EmrysSerenArt.git`
1. Update packages
1. Set the following configurations
     * `DatabaseConnectionString` = {server name}/{database name}
     * `ApiBaseUrl` = {api_url}/api/root
     * `SomeOtherConfig` = 42
1. Setup database by running such-and-such on the command line.
1. Run the script located (here) to seed the data in the database

## User Setup
1. Register a new user

   
## Database

All data for the system including Blog posts, comments on blog posts, and users, will be stored in a SQLite database that is seeded upon building.

## Dependencies

1. Coming soon!