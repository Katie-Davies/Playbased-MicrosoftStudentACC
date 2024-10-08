# Playbased Learning

This is an idea for my Phase 2 Microsoft Student Accelerator. It will be an application that will provide ideas for educators and parents on Playbased activities they can do with their children. They will be able to search by age group, category and materials. Also a random selector.

# Development Steps

## Planning and Design:

- Define detailed requirements and wireframes.
- Create a database schema diagram.

## Backend Development:

- Set up ASP.NET Core Web API project.
<!---* Implement user authentication with ASP.NET Identity.-->
- Design and implement the database schema using Entity Framework Core.
- Develop API endpoints for activities, user, favourites, and searching by age, or category.
- Using Azure Blob storage to store images

## Database

- Set up Azure SQL Database and configure connection strings.

## Frontend Development:


- Implement components for authentication, activity listing, search, and submission forms.
- Integrate frontend with the backend API using request (superagent).
- Use React Router for navigation
- A save favourites feature

### Stretch

- Create user timetable to add activities for the week


## Testing:

- Write unit tests for backend API endpoints.
- Test frontend components and interactions with Jest and React Testing Library. Explore using Storybook

## Deployment:

- Deploy the backend to Azure App Service.
- Deploy the frontend to Azure Static Web Apps or a similar service.

To run project:

```
git clone git@github.com:Katie-Davies/Playbased-MicrosoftStudentACC.git
cd Playbased-MicrosoftStudentACC
cd Frontend
npm run dev
cd ../MyBackend
dotnet run
```

Frontend: http://localhost:5173/
Backend: http://localhost:5091
