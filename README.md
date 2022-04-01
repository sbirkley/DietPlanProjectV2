# DietPlanProjectV2

  At BRANDNAME, we are dedicated to providing optimal nutrition for EVERYONE. 
Whether you are looking to lose weight, maintain, or you are just too busy to sit down and eat, we've got you covered!

  Each BRANDNAME plan provides a full day's worth of food with a focus on quality, plant-based protein to keep you powered up throughout your day.

  BRANDNAME plans can be used short-term (typically 7 - 10 days) to kick-start weight loss or instill healthier eating habits,
or they can be used longer term for on-the-go individuals who simply find it difficult to prepare meals or find time to eat.
At this time, we are primarily targeting individuals with lower TDEEs who may have trouble finding other products to meet their needs.

  Use our tools below to start your BRANDNAME journey.

--- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** --- *** ---


  This console app features an interactive menu with options to view plans, view flavors, and to get matched with a diet plan based upon user input.

(Note that if user input in this section indicates an energy expenditure of less than 1,200, it will default to 1,200. 
This is typically considered the minimum amount of calories a person should have in a day unless otherwise directed by a doctor.)

  Additionally, if the user chooses weight loss as their goal, it will lead them to an optional method to calculate how long it will take them to get to their goal weight based on user input.

** (Also note that I do not recommend this kind of diet-- I kept it simple for the purposes of this project. If I were to expand upon this in the future I would add more whole food
 options and would use the brand's pre-packaged items in addition to certain outside foods the user can freely eat that would be outlined in some kind of list.) **
 
 Font used is "Big" by Glenn Chappell, 4/93.


--- *** --- My 3 chosen features: --- *** ---

1) Master loop which guides user through the entire program.

2) Conversion tools: There are 2 conversions inbedded into the first calculator: lbs to kg and in to cm. 
   The calculator itself takes multiple kinds of user input to get the user's estimated daily calorie expenditure. 
   Additionally, the second calculator converts pounds to calories -- 1 pound is equal
   to 3,500 calories -- in order to output a number of days based upon user input.

3) Countdown clock: I use DateTime to count down to the release of a new flavor within my DisplayFlavors method in the DietObj class.


--- *** --- As far as standard requirements: --- *** ---

> I have 4 classes: Calculator, DietObj, Program, Menu. Objects of three of these can be found in the main switch statement located in Menu.

> I have multiple methods located throughout my program: RunCalc(), WeightTimeCalc(), DisplayFlavors(), DisplayPlans(), RunMenu(), and GetDays(). 
  GetDays() is a method which returns a value.
