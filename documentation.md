
# Currency to Words Project Documentation

 link to the web app on azure [https://currency-to-words.azurewebsites.net](https://currency-to-words.azurewebsites.net)

## Project Name: Currency to Words

### Project Description:

The "Currency to Words" web application is designed to provide a user-friendly interface for converting numerical currency values into their corresponding textual representations. For example, when a user inputs "123.34," the application will produce the output "One hundred and twenty-three dollars and thirty-four cents." This web-based tool aims to streamline the process of converting numeric currency values into easily readable and comprehensible text.

### Web User Interface:

The web user interface of the "Currency to Words" project is designed to be user-friendly and straightforward. It allows users to input numeric currency values and receive the textual representation as output. The design focuses on simplicity and ease of use to provide a seamless experience for users.

### Approach Selection:

**Choice of C#**:

The choice of C# was based on the project specifications and a desire to challenge oneself. It was preferred in the spec, and using C# for web development presented an opportunity for learning. Previous experience with NextJs, React, and familiarity with Vercel and Netlify made the choice to explore Azure for hosting appealing.

### Frontend Tech Stack:

**Frontend Technology: Razor Pages**

- Razor Pages were chosen for several reasons:
  - Simplicity and low ceremony suited the project's straightforward task.
  - Organized code structure with logic contained in a single file alongside its view.
  - Flexibility and adaptability without unnecessary complexity.
  - Full control over HTML for a user-friendly web interface.

**Reasons for Not Choosing Other Options:**

- Single Page Application (SPA): Overkill for this simple converter.
- ASP.NET Core MVC: Potentially over-engineered for a small project.
- Blazor Server and Blazor Client: Not the right fit for this project's scope.

### Backend Tech Stack:

**Backend Technology: ASP.NET Core Web API**

- Chosen for its simplicity, reliability, and seamless integration with Azure.
- Ideal for a small application with a single POST endpoint.
- Consideration of Minimal Hosting APIs and Fast Endpoints, but ASP.NET Core Web API was a safer choice due to project needs.

**Reasons for Not Choosing Other Options:**

- Minimal Hosting APIs: Potential changes in future versions.
- Fast Endpoints: Concerns about open-source library support.
- Azure Functions: Serverless nature not ideal for this API.

### Testing Approach:

- **Testing Framework: MSTest**
- Test methods implemented:
   1. `ConvertToWords_ValidInput`: Conversion of valid currency input (e.g., 123.45) to words and verification of expected output.
   2. `ConvertToWords_ZeroCents`: Conversion of input with zero cents (e.g., 123.00) to words and correct omission of cents.

**What Was Tested:**

- Core functionality of converting numeric currency values to words.
- Different scenarios, including valid input and zero cents.
- Keywords like "trillion," "billion," "million," "thousand," and "hundred" and their "and" placement.

**Suggested Additional Tests (if time allowed):**

1. **Negative Input**: Handling negative currency values (e.g., -50.75).
2. **Large Currency Values**: Testing with very large values (e.g., 1 trillion dollars).
3. **Edge Cases**: Testing with minimum and maximum values.
4. **Invalid Input**: Ensuring proper error handling for invalid inputs.
5. **Input Validation**: Validating input to accept only valid currency values.
6. **Culture-Specific Conversion**: Testing conversions for different cultures if supported.

### Deployment Approach:

**Deployment Platform: Azure**

- Chosen for its seamless integration with ASP.NET Core Web API.
- Azure App Service was the easiest choice for this project's needs.

**Reasons for Not Choosing Other Options:**

- Vercel: Not ideal for ASP.NET Core Web API. Not compatible
- Netlify: Not ideal for ASP.NET Core Web API.
- Heroku: Not as seamless as Azure for ASP.NET Core Web API. and not familiar with it.
- Did not consider AWS or Google Cloud Platform due to lack of familiarity.
