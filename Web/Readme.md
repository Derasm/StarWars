## Considerations
1. What kind of project to make
2. what kind of technology to use
3. how the project should be viewable - install / host?

### What kind of project to make:
Requirement:
- Have to use swapi.dev
- Wanna use C# in some manner - preferrably backend, so no Razor / Blazor stuff. 
- Should be doable within timeframe in a somewhat 80% polished manner.
Initial ideas:
1. Clicker game to be able to afford Star wars stuff
2. Visual implementation of wiki information. 6 buttons, one for each API with information from them. Some kind of way to pin information as well, to have just a bit of neat interaction stuff.
3. Something crazy: Make it possible to choose a Star Wars technology, then have a search on what we have now that is the closest research to that, and potentially feasibility?
4. A basic trivia game with ChatGPT interaction: Choose a subject, make some simple questions based on data available, have ChatGPT make 3 wrong answers to easily fill options. Can be extended with connectivity option,
Based on these, the most likely to be implemented in the timeframe fulfilling requirements:
1. Clicker game - would be super simple for MVP, but not a lot of "meat".
2. Visual implementation of wiki - simple but with pin option it becomes a bit more interesting
3. Not doable in the timeframe, mainly because it requires a validation method for the results from either AI or from Browser result. Also Browser result will be skewed.
4. Trivia - simple but connectivity option potentially a problem, also not a lot of meat on it - though could be fun to do further at some point. 


### Technology
- .NET / C# in some manner for backend. 
- SWAPI.dev
- Would be nice to use VueJS / basic html instead of having to figure out stuff with Webforms / WPF first to save time.
- At least TailwindCSS so i dont have to write a ton of CSS myself and can speed right through this
- Azure hosting the container most likely, with a page on github? Tie the two together?

### Viewable:
- Thinking Azure / Github pages to see if its doable. Dont know if GH pages works with ASP.net, but if it does it would be dope. 
 
## Things to do:
- [x] Setup project on github
- [x] Setup branches: Main, Stage, Dev. Stage is release, Dev merges into Stage. Main is initial setup. When a release has been made, merge Stage into Main for always clean. 
- [] Tie frontend and backend together. Figure out how to send the data to frontend now that API's work as intended. 
- [x] Setup test project
- [x] Write tests for API.
- [] Setup CI/CD pipeline
- [] Add tests to the pipeline
- []Include testing in merge to Stage. 
- [] Setup project on Azure - uncertain yet if this is needed. 
- [] Setup project on Github pages
- [x] Setup project locally
- [x] Add tailwindCss
### MVP
- [x] Get data from SWAPI.dev
- [] Display data in a simple manner
- [] Add a way to pin data
- 

## Current issues
- Display the data in the frontend - currently running into issue of binding backend and frontend together due to razorpages being annoying.
- Transitioning to Console application for that Retro feel.