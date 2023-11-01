## Considerations
1. What kind of project to make
2. what kind of technology to use
3. how the project should be viewable - install / host?

### What kind of project to make:
Requirement:
- Have to use swapi.dev
- Would be nice if it used C# in some manner -
- Should be doable within timeframe in a somewhat 80% polished manner.
Initial ideas:
1. Clicker game to be able to afford Star wars stuff
2. Visual implementation of wiki information. 6 buttons, one for each API with information from them. Some kind of way to pin information as well, to have just a bit of neat interaction stuff.
3. Something crazy: Make it possible to choose a Star Wars technology, then have a search on what we have now that is the closest research to that, and potentially feasibility?
4. A basic trivia game with ChatGPT interaction: Choose a subject, make some simple questions based on data available, have ChatGPT make 3 wrong answers to easily fill options. Can be extended with connectivity option,
Based on these, the most likely to be implemented in the timeframe fulfilling requirements:
- Clicker game - would be super simple for MVP, but not a lot of "meat".
- Visual implementation of wiki - simple but with pin option it becomes a bit more interesting
- ChatGPT - simple but connectivity option potentially a problem.


### Technology
- .NET / C# in some manner for backend. 
- SWAPI.dev
- Would be nice to use VueJS / basic html instead of having to figure out stuff with Webforms / WPF first.
- At least TailwindCSS so i dont have to write a ton of CSS myself and can speed right through this
- Azure hosting the container most likely, with a page on github? Tie the two together?


 
## Things to do:
- [x] Setup project on github
- [] Setup project on Azure
- [x] Setup project locally
- [x] Add tailwindCss
### MVP
- [] Get data from SWAPI.dev
- [] Display data in a simple manner
- [] Add a way to pin data