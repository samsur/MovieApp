# Movie Search App

A  Blazor Server web application built with .NET 9 that allows users to search for movies and view detailed information using the OMDb API.

---
## Learning Objectives

- Create and structure a Blazor Server application with .NET 9
- Build interactive Razor components
- Use data binding with `@bind` directive
- Handle events with `@onclick` and other event handlers
- Integrate with a third-party REST API using HttpClient
- Handle asynchronous operations with async/await
- Work with JSON data serialization/deserialization
- Implement component routing with `@page` directive
- Use component parameters for passing data
- Create reusable Razor components
- Style a responsive web application using Bootstrap 5
- Manage configuration and API keys securely
- Handle errors and loading states gracefully
---

## Getting Started

### 1. Clone the Repository

First, clone this repository to your local machine:

```bash
git clone https://github.com/samsur/MovieApp.git
cd MovieApp
```

### 2. Get Your API Key

## Important: Get Your API Key First

Before running the application, you **MUST** get an OMDb API key:

1. Visit: https://www.omdbapi.com/apikey.aspx
2. Select **FREE** tier (1,000 daily requests)
3. Enter your email address
4. Check your email and click the activation link
5. Copy your API key

### 3. Configure Your API Key

Open `appsettings.json` and replace `your-api-key-here` with your actual API key:

```json
{
  "OmdbApi": {
    "ApiKey": "YOUR_ACTUAL_API_KEY_HERE",
    "BaseUrl": "http://www.omdbapi.com/"
  }
}
```

### 4. Run the Application

```bash
dotnet watch run
```

Or simply:

```bash
dotnet run
```

The application will start at:
- HTTP: https://localhost:5001


## Project Features Implemented

### Core Components

1. **Home Page** (`/`)
   - Welcome message with app description
   - Quick start guide
   - Navigation to search page

2. **Movie Search** (`/search`)
   - Search movies by title
   - Real-time loading indicators
   - Responsive grid layout with movie cards
   - Click any card to view details
   - Error handling for API failures

3. **Movie Details** (`/movie/{ImdbId}`)
   - Comprehensive movie information
   - Poster display with fallback
   - IMDb and Metascore ratings
   - Cast, crew, plot, and more
   - Link to IMDb page
   - Back navigation

### Blazor Concepts Demonstrated

- **Data Binding**: `@bind` directive for two-way binding
- **Event Handling**: `@onclick`, `@onkeydown` events
- **Render Modes**: `@rendermode InteractiveServer`
- **Routing**: Route parameters with `@page` directive
- **Dependency Injection**: Service injection with `@inject`
- **Component Lifecycle**: `OnInitializedAsync` method
- **State Management**: Component-level state
- **Conditional Rendering**: Loading states and error handling

###  Technical Implementation

- **Models**: Clean data models matching API responses
- **Services**: Abstracted API service with interface
- **Error Handling**: Comprehensive try-catch blocks
- **Logging**: Integrated logging throughout
- **Responsive Design**: Bootstrap 5 styling
- **Component CSS**: Scoped styles for each component

## Testing the Application

### Test Search Examples:

Try searching for:
- "Matrix" - Classic sci-fi movie
- "Batman" - Multiple results
- "Star Wars" - Popular franchise

### What to Look For:

1.Search form with input and button
2.Loading spinner during API calls
3.Movie cards with posters, titles, and years
4.Clickable cards that navigate to details
5.Detailed view with all movie information
6.Ratings display (IMDb and Metascore)
7.Responsive layout on mobile devices
8.Error messages for invalid searches
9."No results found" message when appropriate
10.Back navigation from details to search

## Project Structure

```
MovieApp/
├── Models/              # Data models
│   ├── Movie.cs
│   ├── MovieSearchResponse.cs
│   └── MovieDetail.cs
├── Services/            # API services
│   ├── IMovieService.cs
│   └── OmdbMovieService.cs
├── Components/
│   ├── Layout/          # Layout components
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   └── Pages/           # Page components
│       ├── Home.razor
│       ├── MovieSearch.razor
│       └── MovieDetails.razor
├── appsettings.json     # Configuration (ADD YOUR API KEY HERE)
└── Program.cs           # DI & app configuration
```

## Troubleshooting

### "OMDb API key not found"
- Make sure you added your API key to `appsettings.json`

### "Invalid API key"
- Verify you clicked the activation link in your email
- Wait a few minutes after activation

### Component not updating
- This shouldn't happen - `@rendermode InteractiveServer` is configured

### No results found
- Try a different search term
- Check your internet connection
- Verify your API key is working

## Next Steps

Once the app is working, you can:
- Add search filters (year, type)
- Implement pagination
- Create a favorites list
- Customize the styling
-  Add unit tests


## Getting Help

If you encounter issues:
1. Check the browser console (F12) for errors
2. Check the terminal for server errors
3. Verify your API key is activated
4. Try the example searches above
5. Review the requirements.md file
6. Add debugging statement Console.WriteLine to check outputs

