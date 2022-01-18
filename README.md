# BlazorBudget
This is a simple budget application using Blazor and MudBlazor to demonstrate basic understanding.

This simple budget application will store data locally in browser storage. It does not currently ask permission.

TODO:
Add Clear all Budget Items button
Add Clear All Budgets
Move logic into a service. Currently all logic is on main Budget page which means all data needs to flow back up to it in order to be processed. Adding a service will allow it to happen on the individual components rather than push the data back up. Did it this way originally just to learn blazor components stucture.
